using System;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should 
//work well for very big numbers, e.g. n = 100000. 
class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        while (n > 0)
        {
            factorial *= n;
            n--;
        }

        Console.WriteLine("Factorial = {0}", factorial);

        for (int i = 0; i >= 0; i++)
        {
            if (factorial % 10 == 0)
            {
                factorial = factorial / 10;
            }
            else
            {
                Console.WriteLine("The number of trailing zeroes is : {0}", i);
                break;
            }
        }
    }
}

