using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Models;
using Data;

namespace Services
{
    public class SqlRateLimiterService : IRateLimiterService
    {
        private readonly DatabaseHelper _dbHelper;

        public SqlRateLimiterService()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Add a counter route
        public bool AddRoute(string name, int limit)
        {
            try
            {
                string query = @"
                    INSERT INTO dbo.Routes (Name, Limit, CurrentCount, LimiterType, WindowSeconds, WindowStart)
                    VALUES (@Name, @Limit, 0, 'Counter', NULL, NULL)";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Limit", limit)
                };

                _dbHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (SqlException)
            {
                // Route already exists (unique constraint violation)
                return false;
            }
        }

        // Add a time-based route
        public bool AddTimeRoute(string name, int limit, int windowSeconds)
        {
            try
            {
                string query = @"
                    INSERT INTO dbo.Routes (Name, Limit, CurrentCount, LimiterType, WindowSeconds, WindowStart)
                    VALUES (@Name, @Limit, 0, 'Time', @WindowSeconds, GETDATE())";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Limit", limit),
                    new SqlParameter("@WindowSeconds", windowSeconds)
                };

                _dbHelper.ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        // Try to make a request
        public bool TryRequest(string routeName)
        {
            var route = GetRoute(routeName);
            if (route == null) return false;

            // Check if time-based route needs window reset
            if (route is TimeLimiter timeLimiter)
            {
                // Window reset is handled by the TimeLimiter class itself
                if (route.CurrentCount >= route.Limit)
                    return false;
            }
            else
            {
                // Counter-based route
                if (route.CurrentCount >= route.Limit)
                    return false;
            }

            // Increment the counter in database
            string query = @"
                UPDATE dbo.Routes 
                SET CurrentCount = CurrentCount + 1 
                WHERE Name = @Name";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", routeName)
            };

            _dbHelper.ExecuteNonQuery(query, parameters);
            return true;
        }

        // Get route details
        public RateLimiterBase? GetRoute(string routeName)
        {
            string query = "SELECT * FROM dbo.Routes WHERE Name = @Name";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", routeName)
            };

            var dataTable = _dbHelper.ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            var row = dataTable.Rows[0];
            string limiterType = row["LimiterType"].ToString()!;
            string name = row["Name"].ToString()!;
            int limit = Convert.ToInt32(row["Limit"]);
            int currentCount = Convert.ToInt32(row["CurrentCount"]);

            if (limiterType == "Counter")
            {
                var counterLimiter = new CounterLimiter(name, limit);
                // Set the current count using reflection or by making a method
                // For now, we'll create a workaround
                for (int i = 0; i < currentCount; i++)
                {
                    counterLimiter.AllowRequest();
                }
                return counterLimiter;
            }
            else if (limiterType == "Time")
            {
                int windowSeconds = Convert.ToInt32(row["WindowSeconds"]);
                DateTime windowStart = Convert.ToDateTime(row["WindowStart"]);

                var timeLimiter = new TimeLimiter(name, limit, windowSeconds);

                // Check if window expired and reset if needed
                if ((DateTime.Now - windowStart).TotalSeconds >= windowSeconds)
                {
                    // Reset the window in database
                    string resetQuery = @"
                        UPDATE dbo.Routes 
                        SET CurrentCount = 0, WindowStart = GETDATE() 
                        WHERE Name = @Name";

                    var resetParams = new SqlParameter[]
                    {
                        new SqlParameter("@Name", routeName)
                    };

                    _dbHelper.ExecuteNonQuery(resetQuery, resetParams);
                    return timeLimiter;
                }

                // Simulate current count
                for (int i = 0; i < currentCount; i++)
                {
                    timeLimiter.AllowRequest();
                }

                return timeLimiter;
            }

            return null;
        }

        // Reset a route
        public bool ResetRoute(string routeName)
        {
            string query = @"
                UPDATE dbo.Routes 
                SET CurrentCount = 0, WindowStart = GETDATE() 
                WHERE Name = @Name";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", routeName)
            };

            int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}