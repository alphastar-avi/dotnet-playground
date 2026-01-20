using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Number {i}: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                sum += num;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }

        Console.WriteLine($"Sum = {sum}");
    }
}
