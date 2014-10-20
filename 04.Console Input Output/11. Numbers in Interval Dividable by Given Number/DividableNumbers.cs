using System;

class DividableNumbers
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end  number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers in interval dividable by 5:");
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

