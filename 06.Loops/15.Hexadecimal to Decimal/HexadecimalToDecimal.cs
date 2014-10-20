using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string binNum = Console.ReadLine();
        int digit = 0;
        long decimalNum = 0;
        int pow = 0;

        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            digit = binNum[i] - '0';
            if (digit > 9)
            {
                digit = digit - 7; // cases A,B etc... 'A' = 17 therefore 'A' - 7 = 10, 'B' = 18 etc...
            }
            decimalNum += (long)(digit * (Math.Pow(16, pow)));
            pow++;
        }
        Console.WriteLine(decimalNum);
    }
}

