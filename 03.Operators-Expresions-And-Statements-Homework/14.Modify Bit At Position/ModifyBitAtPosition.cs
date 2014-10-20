using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Modifying bit at given position enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value (1 or 0): ");
        int value = int.Parse(Console.ReadLine());
        int result = 0;

        int bit = n & (1 << p);

        if ((bit == 0 && value == 0) || (bit != 0 && value == 1))
        {
            result = n;
        }

        else
        {
            if (bit == 0)
            {
                result = n ^ (1 << p);
            }
            else
            {
                result = n & ~(1 << p);
            }
        }

        Console.WriteLine("Modified number: {0}", result);
    }
}

