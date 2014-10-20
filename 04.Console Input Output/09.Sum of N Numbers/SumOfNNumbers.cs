using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("This program calculates sum of N numbers. Enter N: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;


        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number #{0}: ", i + 1);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}

