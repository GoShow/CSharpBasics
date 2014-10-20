using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        double a = 0;
        double b = 0;
        double h = 0;
        Console.Write("Area of Trapezoid Calculation in cm^2.\nEnter a: ");
        bool isDoubleA = double.TryParse(Console.ReadLine(), out a);
        Console.Write("Enter b: ");
        bool isDoubleB = double.TryParse(Console.ReadLine(), out b);
        Console.Write("Enter h: ");
        bool isDoubleH = double.TryParse(Console.ReadLine(), out h);
        if (isDoubleA && isDoubleB && isDoubleH)
        {
            Console.WriteLine("Trapezoid surface is " + (a + b) * h / 2 + " cm^2.");
        }
        else
        {
            Console.WriteLine("Incorrect entry!");
        }
    }
}    
 
