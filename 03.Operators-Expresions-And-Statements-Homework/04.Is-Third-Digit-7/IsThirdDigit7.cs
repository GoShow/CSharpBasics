using System;

class IsThirdDigit7
{
    static void Main()
    {
        int number;
        Console.Write("Enter number: ");
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (isInt)
        {
            Console.WriteLine( (number / 100) % 10 == 7);
        }
        else
        {
            Console.WriteLine("Incorrect entry!!!");
        }
    }
  
}

