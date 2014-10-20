using System;
class PointInCircleOutOfRectangle
{
    static void Main()
    {
        double x, y;
        Console.Write("This program calculates if point with coordinates x,y is within circle K({0, 0}, 1.5) and out of rectangle (1, 1, width=6, height=2)\nEnter x: ");
        bool isDoubleX = double.TryParse(Console.ReadLine(), out x);
        Console.Write("Enter y: ");
        bool isDoubleY = double.TryParse(Console.ReadLine(), out y);
        if (isDoubleX && isDoubleY)
        {
            bool result = (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 2.25) && ((x <= 5) || ((x >= -1) && ((y <= -1) || (y >= 1))));
            if (result)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }

    }
}
