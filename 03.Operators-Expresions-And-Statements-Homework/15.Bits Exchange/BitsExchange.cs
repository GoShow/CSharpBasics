using System;

class BitsExchange
{
    static void Main()
    {

        int n = 0;
        Console.WriteLine("This is program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.");

        while (true)
        {
            Console.Write("Enter unsigned integer: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Incorrect entry!");
            }
            else
            {
                break;
            }
        }
        //We get the value of the bits 
        int firstMask = 1 << 3;
        int unIntAndFirstMask = n & firstMask;
        int bitThree = unIntAndFirstMask >> 3;

        int secondMask = 1 << 4;
        int unIntAndSecondMask = n & secondMask;
        int bitFour = unIntAndSecondMask >> 4;

        int thirdMask = 1 << 5;
        int unIntAndThirdMask = n & thirdMask;
        int bitFive = unIntAndThirdMask >> 5;

        int fourthMask = 1 << 24;
        int unIntAndFourthMask = n & fourthMask;
        int bitTwentyFour = unIntAndFourthMask >> 24;

        int fifthMask = 1 << 25;
        int unIntAndFifthNask = n & fifthMask;
        int bitTwentyFive = unIntAndFifthNask >> 25;

        int sixthMask = 1 << 26;
        int unIntAndSixthMask = n & sixthMask;
        int bitTwentySix = unIntAndSixthMask >> 26;

        int temp;
        int result;

        //Exchanging bit values
        if (bitThree == 0)
        {
            int mask = ~((int)(1 << 24));
            temp = n & mask;
        }
        else
        {
            int mask = 1 << 24;
            temp = n | mask;
        }
        result = temp;

        if (bitFour == 0)
        {
            int mask = ~((int)(1 << 25));
            temp = result & mask;
        }
        else
        {
            int mask = 1 << 25;
            temp = result | mask;
        }
        result = temp;

        if (bitFive == 0)
        {
            int mask = ~((int)(1 << 26));
            temp = result & mask;
        }
        else
        {
            int mask = 1 << 26;
            temp = result | mask;
        }
        result = temp;

        if (bitTwentyFour == 0)
        {
            int mask = ~((int)(1 << 3));
            temp = result & mask;
        }
        else
        {
            int mask = 1 << 3;
            temp = result | mask;
        }
        result = temp;

        if (bitTwentyFive == 0)
        {
            int mask = ~((int)(1 << 4));
            temp = result & mask;
        }
        else
        {
            int mask = 1 << 4;
            temp = result | mask;
        }
        result = temp;

        if (bitTwentySix == 0)
        {
            int mask = ~((int)(1 << 5));
            temp = result & mask;
        }
        else
        {
            int mask = 1 << 5;
            temp = result | mask;
        }
        result = temp;

        // print our input number in its binary representation
        Console.WriteLine("Modified numer: " + result);
        Console.WriteLine("Binary number = " + Convert.ToString(n, 2).PadLeft(32, '0'));
        // print our modified number in its binary representation
        Console.WriteLine("Bynary modified  number = " + Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

