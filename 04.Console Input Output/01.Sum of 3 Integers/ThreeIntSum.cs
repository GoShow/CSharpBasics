using System;
class ThreeIntSum
{
    static void Main()
    {
        int firstNum, secondNum, thirdNum;
        Console.Write("Enter your first integer : ");
        bool isNum1 = Int32.TryParse(Console.ReadLine(), out firstNum);
        Console.Write("Enter your first integer : ");
        bool isNum2 = Int32.TryParse(Console.ReadLine(), out secondNum);
        Console.Write("Enter your first integer : ");
        bool isNum3 = Int32.TryParse(Console.ReadLine(), out thirdNum);
        if (isNum1 && isNum2 && isNum3)
        {
            Console.WriteLine("The sum of {0},{1} and {2} is {3}", firstNum, secondNum, thirdNum, (firstNum + secondNum + thirdNum));
        }
        else
        {
            Console.WriteLine("Incorrect entry!");
        }
    }
}