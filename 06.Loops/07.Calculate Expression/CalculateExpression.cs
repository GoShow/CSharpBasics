using System;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as 
//the number of combinations).For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only 
//two loops. 

class CalculateExpression
{
    static void Main()
    {
        Console.Write("Enter n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        uint k = uint.Parse(Console.ReadLine());

        Console.WriteLine(CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k)));

    }

    private static BigInteger CalculateFactorial(uint N)
    {
        BigInteger factorial = 1;
        for (uint i = 1; i < N + 1; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}

