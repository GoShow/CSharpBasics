using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binNum = Console.ReadLine();
        int digit = 0;
        long decimalNum = 0;
        int pow = 0;

        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            digit = binNum[i] - '0';
            decimalNum += (long)(digit * (Math.Pow(2, pow)));
            pow++;
        }
        Console.WriteLine(decimalNum);
    }
}

