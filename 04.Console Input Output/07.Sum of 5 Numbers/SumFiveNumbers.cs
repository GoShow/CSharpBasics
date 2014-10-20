using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers separated by space: ");  // you can enter more than 5
        string input = Console.ReadLine();
        string[] numbers =input.Split(' ');
        double sum = 0;

        foreach (var num in numbers)
        {
            sum += Convert.ToDouble(num);
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}

