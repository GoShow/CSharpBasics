using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("This program formats numbers. Enter first number (integer): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number (double): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number (double): ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0}", Convert.ToString(a, 16).PadRight(10));
        Console.Write("|{0}", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0, 10:F2}", b);
        Console.Write("|{0, -10:F3}|", c);
    }
}

