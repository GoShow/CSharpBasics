using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Enter n: " );
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];  
        double result = 0;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number #{0}: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
            result += numbers[i];     
            
        }

        Array.Sort(numbers);   // sorting the array, first and last will be Min and Max after sorting

        Console.WriteLine("Min: {0}", numbers[0]);
        Console.WriteLine("Max: {0}", numbers[numbers.Length - 1]);
        Console.WriteLine("Sum: {0}", result);
        Console.WriteLine("Average: {0:F2}", result / n);
    }
}

