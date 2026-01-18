using System;

Console.Write("Enter your age: ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int age))
{
    Console.WriteLine("Invalid age");
    return;
}

Console.WriteLine(age >= 18 ? "You are over 18 ✅" : "You are under 18 ❌");
