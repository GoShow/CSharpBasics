using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int bit = n & (1 << 3);
        bit = bit >> 3;

        Console.WriteLine("Bit #3 is {0}", bit);
    }
}

