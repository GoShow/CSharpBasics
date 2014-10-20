using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index: ");
        int index = int.Parse(Console.ReadLine());

        int bit = n & (1 << index);
        bit = bit >> index;

        Console.WriteLine("Bit #{0} is {1}", index, bit);
    }
}

