using System;

class AreaOfRectangle
{
    static void Main()
    {

        Console.WriteLine("This program is calculating rectangle's area and perimeter by given \nwidth and height.");
        Console.Write("Enter width in cm: ");
        double width, height;
        bool validateWidth = double.TryParse(Console.ReadLine(), out width);
        Console.Write("Enter height in cm: ");
        bool validateHeight = double.TryParse(Console.ReadLine(), out height);
        if (validateWidth && validateHeight)
        {
            if (height >= 0 && width >= 0)
            {
                Console.WriteLine("Your rectangle's perimeter is " + (height + width) * 2 + " cm");
                Console.WriteLine("Your rectangle's area is " + (height * width) + " cm^2");
            }
            else
            {
                if (height < 0)
                {
                    Console.WriteLine("Invalid value for height!!!");   
                }
                else
                {
                    Console.WriteLine("Invalid value for width!!!");
                }
            }
        }
        else
        {
            Console.WriteLine("Incorrect entry!!!");
        }
    }
}
