using System.Collections.Generic;
using Models;

namespace Services{

    class RateLimiterService : IRateLimiterService
    {   
        //map to hold the relation
        private readonly Dictionary<string, ApiRoute> _routes;

        // Default constructor for _routes as dictonary
        public RateLimiterService()
        {
            _routes = new Dictionary<string, ApiRoute>();
        }

        // To add a new route 
        public bool AddRoute(string name, int limit)
        {
            if (_routes.ContainsKey(name)) return false; // route already present

            _routes[name] = new ApiRoute(name, limit); // create new route 
            return true;
        }

        // Accessing route on request
        public bool TryRequest(string routeName)
        {
            if (!_routes.ContainsKey(routeName)) return false; // the route does not exist so return false 

            return _routes[routeName].AllowRequest();
        }

        // get the route if it present else give null
        public ApiRoute? GetRoute(string routeName)
        {
            if (_routes.ContainsKey(routeName)) return _routes[routeName];

            //if not present return null (the '?' allows null)
            return null;
        }

        public bool ResetRoute(string routeName)
        {
            //if (_routes.ContainsKey(routeName))
            //{
            //    _routes[routeName].Reset();
            //    return true;
            //} Double lookup ... try get value is better i guess

            if (!_routes.TryGetValue(routeName, out var route))
                return false;

            route.Reset();   // resets CurrentCount of that route
            return true;
        }

    }

}
