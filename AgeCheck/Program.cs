using System;

namespace AgeCheck;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (Validator.IsAdult(age))
            Console.WriteLine("Adult");
        else
            Console.WriteLine("Minor");
    }
}
