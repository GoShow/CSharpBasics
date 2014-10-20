using System;

class Circle
{
    static void Main()
    {
        double r;
        Console.Write("This program calculates area and perimeter of circle.\nEnter radius in cm r = ");
        bool isDouble = double.TryParse(Console.ReadLine(), out r);

        if (isDouble)
        {
            Console.WriteLine();
            Console.WriteLine("Circle's area is {0:F2} cm^2.", (Math.PI * Math.Pow(r, 2)));
            Console.WriteLine("Circle's perimeter is {0:F2} cm.", (2 * Math.PI * r));
        }
        else
        {
            Console.WriteLine("Incorrect entry!");
        }
    }
}

