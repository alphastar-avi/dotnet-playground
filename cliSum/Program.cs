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
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }

        Console.WriteLine($"Sum = {sum}");
    }
}
