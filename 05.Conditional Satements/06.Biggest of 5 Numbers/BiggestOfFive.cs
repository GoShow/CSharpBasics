using System;
//Write a program that finds the biggest of five numbers by using only five if statements. 
class BiggestOfFive
{
    static void Main()
    {
        // I made 2 different solutions with 1 and with no "if" statements

        // first solution
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number #{0}: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }
        double biggestNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
            }
        }
        Console.WriteLine("Biggest number is: {0}", biggestNumber);

        //second solution

        //double[] numbers = new double[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write("Enter number #{0}: ", i + 1);
        //    numbers[i] = double.Parse(Console.ReadLine());
        //}

        //Array.Sort(numbers);
        //Console.WriteLine("Biggest number is: {0}", numbers[numbers.Length - 1]);
    }
        
        
}

