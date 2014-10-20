using System;
using System.Numerics;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
//Use only one loop. Print the result with 5 digits after the decimal point.
class SumCalculation
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        double y;
        double sum = 1.0;
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            y = Math.Pow(x, i);
            sum += ((double)factorial / (double)y);
            
        }
        Console.WriteLine("Sum = {0:F5}", sum);  
    }
}

