using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter number to check if it is prime: ");
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }

    static bool IsPrime(long number)
    {
        bool primeChecker = true;
        if (number <= 1)
        {
            primeChecker = false;
            return primeChecker;        
        }
        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                primeChecker = false;
            }
        }
       
        return primeChecker;
    }
}

