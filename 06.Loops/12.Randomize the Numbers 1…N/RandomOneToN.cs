using System;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
class RandomOneToN
{
    static void Main()
    {
        Random generator = new Random();
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int numbersCounter = 0;

        for (int i = 0; i < numbers.Length; i++) // putting numbers from 1 to n in array
        {
            numbers[i] = i + 1;
        }

        while (true)
        {
            int newIndex = generator.Next(0, n);  // random index in arrat

            if (numbers[newIndex] != 0)   //printing number at index and making it 0 when used, if it is allready 0 do nothing
            {
                Console.Write(numbers[newIndex] + " ");
                numbers[newIndex] = 0;
                numbersCounter++;  // counting printed numbers
            }

            if (numbersCounter == n)  // if all numbers are printed - break the while loop
            {
                break;
            }
        }
        Console.WriteLine();
    }
}

