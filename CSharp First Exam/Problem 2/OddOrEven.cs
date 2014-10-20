using System;

class OddOrEven
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        for (int i = 0; i < 2 * n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            long diff = Math.Max(oddSum, evenSum) - Math.Min(oddSum, evenSum);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}

