using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        Random generator = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(generator.Next(min, max + 1) + " ");
        }
    }
}

