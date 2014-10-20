using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number (odd?): ");
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (isInt)
        {
            Console.WriteLine( number % 2 != 0);
        }
        else
        {
            Console.WriteLine("Incorrerct entry!!!");
        }
    }
}