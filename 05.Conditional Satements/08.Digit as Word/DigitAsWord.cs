using System;

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). 
//Print “not a digit” in case of invalid inut. Use a switch statement. 
class DigitAsWord
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string digit = Console.ReadLine();
        string digitAsWord = null;

        switch(digit)
        {
            case "0":
                digitAsWord = "zero";
                break;
            case "1":
                digitAsWord = "one";
                break;
            case "2":
                digitAsWord = "two";
                break;
            case "3":
                digitAsWord = "three";
                break;
            case "4":
                digitAsWord = "four";
                break;
            case "5":
                digitAsWord = "five";
                break;
            case "6":
                digitAsWord = "six";
                break;
            case "7":
                digitAsWord = "seven";
                break;
            case "8":
                digitAsWord = "eight";
                break;
            case "9":
                digitAsWord = "nine";
                break;
            default:
                digitAsWord = "not a digit";
                break;
        }
        Console.WriteLine(digitAsWord);
    }
}

