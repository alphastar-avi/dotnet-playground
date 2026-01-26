using Models;

namespace Services
{
    // Interface for just defining a contract
    interface IRateLimiterService
    {  //add a new API route
        bool AddRoute(string name, int limit);
        //process a request for a route.
        bool TryRequest(string routeName);
        // get route detail
        ApiRoute? GetRoute(string routeName);
    }
}
