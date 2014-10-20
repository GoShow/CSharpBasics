using System;

class DivideWithoutRemainderCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);
        if (isInt)
        {
            Console.WriteLine(number % 35 == 0);   
        }
        else
        {
            Console.WriteLine("Incorrect entry!!!");
        }
    }
}

