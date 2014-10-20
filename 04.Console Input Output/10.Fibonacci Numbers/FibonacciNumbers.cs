using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("First N members of Fibonacci sequence. Enter N: ");
        int n = int.Parse(Console.ReadLine());

        double first = 0;
        double second = 1;
        double sum = first + second;
        Console.Write("{0} {1} ", first, second);

        for (int i = 2; i < n; i++)
        {
            Console.Write(sum + " ");
            first = second;
            second = sum;
            sum = first + second;
        }
    }
}
