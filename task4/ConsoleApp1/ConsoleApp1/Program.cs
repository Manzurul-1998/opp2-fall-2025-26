using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
