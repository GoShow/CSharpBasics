using System;

//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. 
//The output should be a variable of type string. Do not use the built-in .NET functionality. 
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number : ");
        long n = long.Parse(Console.ReadLine());
        long remainder = 0;
        string binaryNum = null;

        while (n > 0)
        {
            remainder = n % 2;
            binaryNum = Convert.ToString(remainder) + binaryNum;
            n = n / 2;
        }
        Console.WriteLine("Binary representation : {0}", binaryNum);
    }
}

