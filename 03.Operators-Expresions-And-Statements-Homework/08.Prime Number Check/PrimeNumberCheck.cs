using System;


class IsNumberPrime
{
    static void Main()
    {
        bool isPrime = true;
        int number;
        Console.Write("Enter your number (prime?): ");
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (number <= 0)
        {
            isPrime = false;
            Console.WriteLine(isPrime);
            return;
        }
        if (isInt)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}
