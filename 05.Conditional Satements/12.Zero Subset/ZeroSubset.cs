using System;
 
class ZeroSubset
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("Subsets with sum 0: ");
        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("Numbers with sum = 0: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
        }
        else
        {

            if (a + b + c + d + e == 0) Console.WriteLine("{0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
            if (a + b + c + d == 0) Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
            if (a + b + c + e == 0) Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, e);
            if (a + b + d + e == 0) Console.WriteLine("{0}, {1}, {2}, {3}", a, b, d, e);
            if (a + c + d + e == 0) Console.WriteLine("{0}, {1}, {2}, {3}", a, c, d, e);
            if (a + b + c == 0) Console.WriteLine("{0}, {1}, {2}", a, b, c);
            if (a + b + d == 0) Console.WriteLine("{0}, {1}, {2}", a, b, d);
            if (a + b + e == 0) Console.WriteLine("{0}, {1}, {2}", a, b, e);
            if (a + c + d == 0) Console.WriteLine("{0}, {1}, {2}", a, c, d);
            if (a + c + e == 0) Console.WriteLine("{0}, {1}, {2}", a, c, e);
            if (a + d + e == 0) Console.WriteLine("{0}, {1}, {2}", a, d, e);
            if (a + b == 0) Console.WriteLine("{0}, {1}", a, b);
            if (a + c == 0) Console.WriteLine("{0}, {1}", a, c);
            if (a + d == 0) Console.WriteLine("{0}, {1}", a, d);
            if (a + e == 0) Console.WriteLine("{0}, {1}", a, e);
            if (b + c + d + e == 0) Console.WriteLine("{0}, {1}, {2}, {3}", b, c, d, e);
            if (b + c + d == 0) Console.WriteLine("{0}, {1}, {2}", b, c, d);
            if (b + c + e == 0) Console.WriteLine("{0}, {1}, {2}", b, c, e);
            if (b + d + e == 0) Console.WriteLine("{0}, {1}, {2}", b, d, e);
            if (b + c == 0) Console.WriteLine("{0}, {1}", b, c);
            if (b + d == 0) Console.WriteLine("{0}, {1}", b, d);
            if (b + e == 0) Console.WriteLine("{0}, {1}", b, e);
            if (c + d + e == 0) Console.WriteLine("{0}, {1}, {2}", c, d, e);
            if (c + d == 0) Console.WriteLine("{0}, {1}", c, d);
            if (c + e == 0) Console.WriteLine("{0}, {1}", c, e);
            if (d + e == 0) Console.WriteLine("{0}, {1}", d, e);
 
            else Console.WriteLine("no zero subset");
        }
    }
}