using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Check bit at given position (1?) enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        bool isOne = false;

        int bit = n & (1 << p);
        if (bit != 0)
        {
            isOne = true;
        }
        

        Console.WriteLine(isOne);
    }
}

