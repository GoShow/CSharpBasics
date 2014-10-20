using System;
class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string wholeSequence = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string currSequence = "";
            for (int k = 0; k < 8; k++)
            {
                int lastDigit = (number & (1 << k)) >> k;
                currSequence = lastDigit + currSequence;
            }
            wholeSequence += currSequence;
        }
        char[] digits = wholeSequence.ToCharArray();

        for (int i = 0; i < digits.Length; i++)
        {
            int position = 1 + i * step;

            if (position > digits.Length - 1)
            {
                break;
            }
            digits[position] = '1';
        }

        string currNumber = "";
        for (int i = 0; i < digits.Length; i++)
        {
            currNumber += digits[i];
            if ((i + 1) % 8 == 0)
            {
                int result = Convert.ToInt32(currNumber, 2);
                Console.WriteLine(result);
                currNumber = "";
            }
        }
    }
}

