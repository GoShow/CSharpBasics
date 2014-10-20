using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single 
//line, separated by a space. 
class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(i + 1 + " ");
        }
    }
}

