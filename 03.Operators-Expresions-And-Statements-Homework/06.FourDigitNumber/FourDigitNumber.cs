using System;

class FourDigitNumber
{
    static void Main()
    {
        int[] digits = new int[4];
        int sumOfDigits = 0;
        int n = 0;

        while (true)
        {

            Console.Write("Enter a four-digit number: ");
            n = int.Parse(Console.ReadLine());

            if (n < 1000 || n > 9999)
            {
                Console.WriteLine("Incorrect entry!");
            }
            else
            {
                break;
            }
        }

        for (int i = 3; i >= 0; i--)
        {
            digits[i] = n % 10;
            sumOfDigits += digits[i];
            n = n / 10;

        }

        Console.WriteLine("Sum of digits: {0}", sumOfDigits);
        Console.Write("Reversed :");
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", digits[3], digits[0], digits[1], digits[2]);
        Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", digits[0], digits[2], digits[1], digits[3]);

    }
}

