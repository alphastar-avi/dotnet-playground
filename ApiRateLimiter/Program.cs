using Services;

using ApiRateLimiter.Cli;

class Program
{
    static void Main(string[] args)
    {
        //var rateLimiter = new RateLimiterService();
        IRateLimiterService rateLimiter = new RateLimiterService(); //DI using interface

        ApiRateLimiterCli.Start(rateLimiter);
    }
}
