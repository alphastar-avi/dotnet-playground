using System;

class Program
{
    static void Main(string[] args){
        
        PrintHeader();

        while (true){
            Console.Write("> ");
            string? input = Console.ReadLine();

            //White space or null input can be skipped
            if (string.IsNullOrWhiteSpace(input))
                continue;

            string command = input.Trim().ToLower();

            //match from the terminal
            switch (command){
                case "help":
                    PrintHelp();
                    break;

                case "clear":
                    Console.Clear();
                    PrintHeader();
                    break;

                case "exit":
                    Console.WriteLine("Exiting application...");
                    return;

                default:
                    PrintError($"Unknown command: {command}");
                    break;
            }
        }
    }

    //Default message 
    static void PrintHeader(){
        Console.WriteLine();
        Console.WriteLine("API Rate Limiter");
        Console.WriteLine("Type help for commands");
        Console.WriteLine("---------------------");
        Console.WriteLine();
    }

    static void PrintHelp(){

        Console.WriteLine();
        Console.WriteLine("Avilable commands:");
        Console.WriteLine();
        Console.WriteLine("help - Show help");
        Console.WriteLine("clear - Clear console");
        Console.WriteLine("exit  - Exit application");
        Console.WriteLine();
    }

    //So that we can reuse 
    static void PrintError(string message){
        Console.WriteLine($"Error: {message}");
    }
}
