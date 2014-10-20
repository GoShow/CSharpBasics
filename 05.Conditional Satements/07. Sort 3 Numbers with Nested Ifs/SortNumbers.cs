using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. 
//Don’t use arrays and the built-in sorting functionality. 
class SortNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        double first = 0;
        double second = 0;
        double third = 0;
    
        if (a > b)
        {
            if (b > c)
            {
                first = a;
                second = b;
                third = c;
            }
            else
            {
                if (c > a)
                {
                    first = c;
                    second = a;
                    third = b;
                }
                else
                {
                    first = a;
                    second = c;
                    third = b;
                }
            }
        }
        else
        {
            if (a > c)
            {
                first = b;
                second = a;
                third = c;
            }
            else
            {
                if (c > b)
                {
                    first = c;
                    second = b;
                    third = a;
                }
                else
                {
                    first = b;
                    second = c;
                    third = a;
                }
            }
        }
        Console.WriteLine("Descending order: {0}, {1}, {2}", first, second, third);
        if (a == b && b == c)
        {
            Console.WriteLine("Numbers are equal.");
        }
    }
}

