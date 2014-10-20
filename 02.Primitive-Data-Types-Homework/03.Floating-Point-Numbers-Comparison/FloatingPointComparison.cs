using System;

//Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly
//compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, 
//we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

class FloatingPointComparison
{
    static void Main()
    {
        Console.WriteLine("Floating point numbers comparison with precision of 0.000001");
        Console.Write("Enter your first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        double deduction = firstNumber - secondNumber;
        deduction = Math.Abs(deduction);
        if (deduction < 0.000001)
        {
            Console.WriteLine(firstNumber + " = " + secondNumber);
            return;
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine(firstNumber + " > " + secondNumber);
        }
        else
        {
            Console.WriteLine(firstNumber + " < " + secondNumber);
        }

    }
}


