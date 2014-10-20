using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
class FactorialDivision
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = k + 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
        Console.WriteLine("N! / K! = {0}", factorial);
    }
}
