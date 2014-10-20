using System;

class NumbersSequence
{
    static void Main()
    {
        Console.Write("This program prints numbers from 1 to N. Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

