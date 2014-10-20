using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = (Math.Pow(b, 2) - 4 * a * c);
        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + -Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("There are 2 real roots x1 = {0}, x2 = {1}", x1, x2);
        }

        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Only 1 real root x = {0}", x);
        }
        else
        {
            Console.WriteLine("No real roots.");
        }
    }
}

