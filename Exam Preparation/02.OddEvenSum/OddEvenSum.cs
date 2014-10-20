using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long oddSum = 0;
        long evenSum = 0;

        for (int i = 1; i < 2 * n + 1; i++)
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
            Console.WriteLine("Yes, sum={0}", evenSum);
        }

        else
        {
            long diff = Math.Max(oddSum, evenSum) - Math.Min(oddSum, evenSum);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}

