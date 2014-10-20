using System;
using System.Numerics;

//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
 
class CatalanNumbers
{
    
    static void Main()
    {
        BigInteger nElement;
        Console.Write("This program calculates N-th Catalan number.\nEnter n: ");
        uint n = uint.Parse(Console.ReadLine());

        nElement = CalculateFactorial((n + 1), (2 * n)) / CalculateFactorial(1, n + 1);
        Console.WriteLine("The N-th element = {0}", nElement);


    }
    private static BigInteger CalculateFactorial(uint startNumber, uint N) // making own method to find factorial
    {
        BigInteger factorial = (BigInteger)startNumber;
        for (uint i = startNumber + 1; i < N + 1; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}