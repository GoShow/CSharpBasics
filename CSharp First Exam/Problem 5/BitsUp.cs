using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string bitNum = null;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string currSequence = null;
            for (int pos = 0; pos < 8; pos++)
            {
                int lastBit = (number & (1 << pos)) >> pos;
                currSequence = lastBit + currSequence;
            }

            bitNum += currSequence;
        }

        char[] bits = new char[n * 8];

        for (int i = 0; i < bits.Length; i++)
        {
            bits[i] = bitNum[i];
        }

        for (int i = 0; i < bits.Length; i++)
        {
            int position = 1 + step * i;

            if (position >= bitNum.Length)
            {
                break;
            }
            bits[position] = '1';
        }
        string newBinNum = null;
        for (int i = 0; i < bits.Length; i++)
        {
            newBinNum += bits[i];
            if ((i + 1) % 8 == 0)
            {
                Console.WriteLine(Convert.ToUInt32(newBinNum, 2));
                newBinNum = null;
            }
        }
    }
}

