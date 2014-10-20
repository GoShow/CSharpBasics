using System;

//Write a program that reads a number n and a sequence of n integers, sorts them and prints them
class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number #{0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());    
        }

        Array.Sort(numbers);
        Console.WriteLine("Sorted numbers: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
    }
}

