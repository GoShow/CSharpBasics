using System;

class BitExchangeAdvanced
{
    static void Main()
    {            
        
        Console.Write("Enter an unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first position you would like to exchange: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter the second position you would like to exchange with the first position: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of bits you would like to exchange inbetween: ");
        int k = int.Parse(Console.ReadLine());
        int bitP;
        int bitQ;

        if (p + k > 32 || q + k > 32)
        {
            Console.WriteLine("Out of range");
            return;
        }

        if ((p < q && p + k - 1 >= q) || (p > q && q + k - 1 >= p) || p == q)
        {
            Console.WriteLine("Overlapping");
            return;
        }

        for (int count = 0; count < k; count++)
        {
            bitP = (int)(number >> p) & 1;
            bitQ = (int)(number >> q) & 1;

            number = number & (uint)(~(1 << q)) | (uint)(bitP << q);
            number = number & (uint)(~(1 << p)) | (uint)(bitQ << p);

            p++;
            q++;
        }
        Console.WriteLine(number);
    }
}
