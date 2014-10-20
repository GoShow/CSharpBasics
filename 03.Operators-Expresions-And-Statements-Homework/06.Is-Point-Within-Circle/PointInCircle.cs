using System;

class IsPointWithinCircle
{
    static void Main()
    {
        double x;
        double y;
        Console.Write("This program calculates if point with coordinates x,y is within circle \nK({0,0}, 2) \nEnter x: ");
        bool isDoubleX = double.TryParse(Console.ReadLine(),out x);
        Console.Write("Enter y: ");
        bool isDoubleY = double.TryParse(Console.ReadLine(),out y);
        bool isWithinCircle = false;

        if (isDoubleX && isDoubleY)
	    {
            if ( x * x + y * y <= 2 * 2)
	        {
                isWithinCircle = true;
	        }

            Console.WriteLine(isWithinCircle);
	    }
        else
	    {
            Console.WriteLine("Incorrect entry!");
    	}
    }
}
