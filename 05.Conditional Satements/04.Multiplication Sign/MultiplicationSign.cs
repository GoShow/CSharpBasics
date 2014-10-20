using System;
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
class MultiplicationSign
{
    static void Main()
    {

        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        

        if ((a < 0 && b < 0) || (a < 0 && c < 0) || ( b < 0 && c < 0) ||(a > 0 && b > 0 && c > 0))
        {
            Console.WriteLine("Sign of product (a * b * c) is \"+\".");
        }

        else if ( a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Result of product (a * b * c) is 0.");
        }

        else
        {
            Console.WriteLine("Sign of product (a * b * c) is \"-\".");
        }
    }
}

