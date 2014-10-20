using System;
using System.Collections.Generic;

//Write a method that calculates all prime numbers in given range and returns them as list of integers.
//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a 
//separate line) and prints all primes in their range, separated by a comma.

class PrimesInRange
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Prime numbers in range {0} - {1}: ", start, end);

        for (int i = 0; i < FindPrimesInRange(start, end).Count; i++)
        {
            if (i == FindPrimesInRange(start, end).Count - 1)
            {
                Console.WriteLine(FindPrimesInRange(start, end)[i]);
                break;
            }
            Console.Write(FindPrimesInRange(start, end)[i] + ", ");
        }

        Console.WriteLine();
    }
    static List<int> FindPrimesInRange(int startNum,int endNum)
    {
        List<int> primes = new List<int>();

        if (startNum <2)
        {
            startNum = 2;
        }

        for (int i = startNum; i <= endNum; i++)
        {

            bool isPrime = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }

        return primes;
    }
    
}

