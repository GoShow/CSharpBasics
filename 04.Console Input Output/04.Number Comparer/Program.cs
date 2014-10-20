using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("{0} is greater.", Math.Max(a, b));
    }
}