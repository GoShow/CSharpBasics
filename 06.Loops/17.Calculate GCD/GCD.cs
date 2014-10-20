using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean 
//algorithm (find it in Internet). 
class GCD
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        int gcd = 0;
        int result = 0;

        if (b == 0)
        {
            gcd = a;
        }
        else if (a == 0)
        {
            gcd = b;
        }
        else
        {
            c = Math.Max(a, b);
            a = Math.Min(a, b);
            b = c;
            do
            {
                result = a % b;
                if (result == 0)
                {
                    gcd = b;
                    break;
                }
                else
                {
                    a = b;
                    b = result;
                }
            }
            while (true);
        }

        Console.WriteLine("Greatest Common Dividor = {0}", gcd);
    }
}


