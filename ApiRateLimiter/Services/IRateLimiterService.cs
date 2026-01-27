using Models;

namespace Services
{
    // Interface for just defining a contract ( exposing the capabilities )
    interface IRateLimiterService
    {  //add a new API route
        bool AddRoute(string name, int limit);
        //process a request for a route.
        bool TryRequest(string routeName);
        // get route detail
        ApiRoute? GetRoute(string routeName);
        // to reset the current count for a route to 0
        bool ResetRoute(string routeName);

    }
}
