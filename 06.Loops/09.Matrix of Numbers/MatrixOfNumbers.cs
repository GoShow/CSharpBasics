using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

