using System;

//Define a method Fib(n) that calculates the nth Fibonacci number. 
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }

    static long Fib(int n)
    {
        long a = 0;
        long b = 1;
        long result = a + b;

        for (int i = 2; i <= n; i++)
        {
            a = b;
            b = result;
            result = a + b; 
        }
        return result;
    }
}

