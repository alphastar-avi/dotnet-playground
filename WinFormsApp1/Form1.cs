namespace WinFormsApp1
{
    public partial class deletethis : Form
    {
        private readonly IRateLimiterService _rateLimiter;

        public deletethis()
        {
            InitializeComponent();
            _rateLimiter = new RateLimiterService();
        }

        // Add Counter Route Button
        private void btnAddCounter_Click(object sender, EventArgs e)
        {
            string routeName = txtCounterRouteName.Text.Trim();

            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Please enter a route name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCounterLimit.Text, out int limit) || limit <= 0)
            {
                MessageBox.Show("Please enter a valid limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool added = _rateLimiter.AddRoute(routeName, limit);

            if (added)
            {
                MessageBox.Show($"Counter route '{routeName}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCounterRouteName.Clear();
                txtCounterLimit.Clear();
            }
            else
            {
                MessageBox.Show("Route already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Add Time Route Button
        private void btnAddTime_Click(object sender, EventArgs e)
        {
            string routeName = txtTimeRouteName.Text.Trim();

            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Please enter a route name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTimeLimit.Text, out int limit) || limit <= 0)
            {
                MessageBox.Show("Please enter a valid limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtTimeWindow.Text, out int windowSeconds) || windowSeconds <= 0)
            {
                MessageBox.Show("Please enter valid window seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool added = _rateLimiter.AddTimeRoute(routeName, limit, windowSeconds);

            if (added)
            {
                MessageBox.Show($"Time route '{routeName}' added successfully!\n({limit} requests per {windowSeconds} seconds)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimeRouteName.Clear();
                txtTimeLimit.Clear();
                txtTimeWindow.Clear();
            }
            else
            {
                MessageBox.Show("Route already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Send Request Button
        private void btnRequest_Click(object sender, EventArgs e)
        {
            string routeName = txtRequestRoute.Text.Trim();

            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Please enter a route name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool allowed = _rateLimiter.TryRequest(routeName);

            if (allowed)
            {
                lblRequestResult2.Text = "✓ Request ALLOWED";
                lblRequestResult2.ForeColor = Color.Green;
            }
            else
            {
                lblRequestResult2.Text = "✗ Request DENIED";
                lblRequestResult2.ForeColor = Color.Red;
            }
        }

        // Check Status Button
        private void btnStatus_Click(object sender, EventArgs e)
        {
            string routeName = txtStatusRoute.Text.Trim();

            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Please enter a route name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var route = _rateLimiter.GetRoute(routeName);

            if (route == null)
            {
                MessageBox.Show("Route not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = $"Route: {route.Name}\r\n";
            status += $"Limit: {route.Limit}\r\n";
            status += $"Used: {route.CurrentCount}\r\n";
            status += $"Available: {route.Limit - route.CurrentCount}\r\n";

            if (route is TimeLimiter timeLimiter)
            {
                status += $"\r\nWindow: {timeLimiter.WindowSeconds} seconds\r\n";
                status += $"Window Started: {timeLimiter.WindowStart:HH:mm:ss}";
            }

            txtStatusDisplay.Text = status;
        }

        // Reset Route Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            string routeName = txtResetRoute.Text.Trim();

            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Please enter a route name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool reset = _rateLimiter.ResetRoute(routeName);

            if (reset)
            {
                MessageBox.Show($"Route '{routeName}' has been reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResetRoute.Clear();
            }
            else
            {
                MessageBox.Show("Route not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Empty event handlers (you can delete these if you want)
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void grpRequest_Enter(object sender, EventArgs e) { }
        private void grpStatus_Load(object sender, EventArgs e) { }

        private void btnAddTime_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }
    }
}