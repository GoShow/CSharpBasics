using System;

//Write a program that finds the biggest of three numbers.
class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        double biggestNumber = Math.Max(a, b);
        biggestNumber = Math.Max(biggestNumber , c);

        Console.WriteLine("Biggest number is: {0}", biggestNumber);
    }
}

