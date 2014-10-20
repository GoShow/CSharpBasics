using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number : ");
        long n = long.Parse(Console.ReadLine());
        long remainder = 0;
        string hexNum = null;

        while (n > 0)
        {
            remainder = n % 16;

            switch (remainder)
            {
                case 10:
                    hexNum = "A" + hexNum;
                    break;
                case 11:
                    hexNum = "B" + hexNum;
                    break;
                case 12:
                    hexNum = "C" + hexNum;
                    break;
                case 13:
                    hexNum = "D" + hexNum;
                    break;
                case 14:
                    hexNum = "E" + hexNum;
                    break;
                case 15:
                    hexNum = "F" + hexNum;
                    break;
                default:
                    hexNum = remainder + hexNum;
                    break;
            }

            n = n / 16;
        }
        Console.WriteLine("Hexadecimal representation : {0}", hexNum);
    }
}

