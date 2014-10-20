using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string bitSequence = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string currSequence = ConvertToBinString(number);
            bitSequence += currSequence;
        }

        char[] bits = bitSequence.ToCharArray();

        SetBitAtPosition(step, bits);
        PrintResult(bits);
    }


    private static string ConvertToBinString(int number)
    {
        string currSequence = "";
        for (int k = 0; k < 8; k++)
        {
            int lastBit = (number & (1 << k)) >> k;
            currSequence = lastBit + currSequence;
        }
        return currSequence;
    }


    private static void SetBitAtPosition(int step, char[] bits)
    {
        for (int i = 0; i < bits.Length; i++)
        {
            int position = 1 + i * step;

            if (position > bits.Length - 1)
            {
                break;
            }

            bits[position] = '1';
        }
    }

    private static void PrintResult(char[] bits)
    {
        string resultNum = "";
        for (int i = 0; i < bits.Length; i++)
        {
            resultNum += bits[i];

            if ((i + 1) % 8 == 0)
            {
                Console.WriteLine(Convert.ToInt32(resultNum, 2));
                resultNum = "";
            }
        }
    }
}

