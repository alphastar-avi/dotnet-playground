using System;
using Services;
using Models;

class Program
{
    static void Main(string[] args)
    {
    
        //var rateLimiter = new RateLimiterService();
        IRateLimiterService rateLimiter = new RateLimiterService(); //DI using interface

        // welcome message 
        PrintHeader();

        // until control + c, run this loop 
        while (true)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();

            // White space or null input can be skipped
            if (string.IsNullOrWhiteSpace(input))
                continue;

            string command = input.Trim().ToLower();

            // match from the terminal
            switch (command)
            {
                case "help":
                    PrintHelp();
                    break;

                case "add":
                    HandleAdd(rateLimiter);
                    Console.WriteLine();
                    break;

                case "addtime":
                    HandleAddTime(rateLimiter);
                    Console.WriteLine();
                    break;

                case "request":
                    HandleRequest(rateLimiter);
                    Console.WriteLine();
                    break;

                case "status":
                    HandleStatus(rateLimiter);
                    Console.WriteLine();
                    break;

                case "clear":
                    Console.Clear();
                    PrintHeader();
                    break;

                case "exit":
                    Console.WriteLine("Exiting application...");
                    return;

                case "reset":
                    HandleReset(rateLimiter);
                    Console.WriteLine();
                    break;

                default:
                    PrintError("Unknown command");
                    break;
            }
        }
    }

    // Add a new API route with counter strategy
    static void HandleAdd(IRateLimiterService service)
    {
        Console.Write("Route name: ");
        string? name = Console.ReadLine();

        Console.Write("Limit: ");
        string? limitInput = Console.ReadLine();

        // check if limit is a valid integer
        if (!int.TryParse(limitInput, out int limit) || limit <= 0)
        {
            PrintError("Invalid limit");
            return;
        }

        // try to add route with counter strategy
        bool added = service.AddRoute(name!, limit);

        if (added)
            Console.WriteLine("Counter route added successfully");
        else
            PrintError("Route already exists");
    }

    // Add a new API route with time strategy
    static void HandleAddTime(IRateLimiterService service)
    {
        Console.Write("Route name: ");
        string? name = Console.ReadLine();

        Console.Write("Limit: ");
        string? limitInput = Console.ReadLine();

        Console.Write("Window (seconds): ");
        string? windowInput = Console.ReadLine();

        // check if inputs are valid integers
        if (!int.TryParse(limitInput, out int limit) || limit <= 0)
        {
            PrintError("Invalid limit");
            return;
        }

        if (!int.TryParse(windowInput, out int windowSeconds) || windowSeconds <= 0)
        {
            PrintError("Invalid window seconds");
            return;
        }

        // try to add route with time strategy
        bool added = service.AddTimeRoute(name!, limit, windowSeconds);

        if (added)
            Console.WriteLine($"Time route added successfully ({limit} requests per {windowSeconds} seconds)");
        else
            PrintError("Route already exists");
    }

    // simulate api request
    static void HandleRequest(IRateLimiterService service)
    {
        Console.Write("Route name: ");
        string? name = Console.ReadLine();

        bool allowed = service.TryRequest(name!);

        if (allowed)
            Console.WriteLine("Request allowed");
        else
            PrintError("Request denied");
    }

    // show route usage details
    static void HandleStatus(IRateLimiterService service)
    {
        Console.Write("Route name: ");
        string? name = Console.ReadLine();

        var route = service.GetRoute(name!);

        if (route == null)
        {
            PrintError("Route not found");
            return;
        }

        Console.WriteLine($"Route: {route.Name}");
        Console.WriteLine($"Limit: {route.Limit}");
        Console.WriteLine($"Used : {route.CurrentCount}");
        
        // show additional info for time-based routes
        if (route is TimeLimiter timeLimiter)
        {
            Console.WriteLine($"Window: {timeLimiter.WindowSeconds} seconds");
            Console.WriteLine($"Window started: {timeLimiter.WindowStart:HH:mm:ss}");
        }
    }

    static void HandleReset(IRateLimiterService service)
    {
        Console.Write("Route name: ");
        string? name = Console.ReadLine();

        if (!service.ResetRoute(name!))
            PrintError("Route not found");
        else
            Console.WriteLine("Route Limit resetted");
    }


    // default startup message
    static void PrintHeader()
    {
        Console.WriteLine();
        Console.WriteLine("API Rate Limiter");
        Console.WriteLine("Type help for commands");
        Console.WriteLine("---------------------");
        Console.WriteLine();
    }

    // show available cli commands
    static void PrintHelp()
    {
        Console.WriteLine();
        Console.WriteLine("Available commands:");
        Console.WriteLine();
        Console.WriteLine("add      - Add new counter route");
        Console.WriteLine("addtime  - Add new time-based route");
        Console.WriteLine("request - Send request to route");
        Console.WriteLine("status  - View route usage");
        Console.WriteLine("help    - Show help");
        Console.WriteLine("clear   - Clear console");
        Console.WriteLine("exit    - Exit application");
        Console.WriteLine();
    }

    // to print error in consistent format
    static void PrintError(string message)
    {
        Console.WriteLine($"Error: {message}");
    }
    
    
}//moving to next branch
