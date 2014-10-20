using System;

//Write a program to find the longest area of equal elements in array of strings. You first should read 
//an integer n and n strings (each at a separate line), then find and print the longest sequence of equal
//elements (first its length, then its elements). If multiple sequences have the same maximal length, 
//print the leftmost of them. 
class LongestArea
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        string[] input = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter string #{0}: ", i + 1);
            input[i] = Console.ReadLine();
        }
        
        string currString = input[0];
        Array.Sort(input);
        int currLength = 1;
        int bestLength = currLength;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                currLength++;
            }

            else
            {
                currLength = 1;
            }

            if (bestLength < currLength)
            {
                bestLength = currLength;
                currString = input[i];
            }
        }
        Console.WriteLine(bestLength);
        for (int i = 0; i < bestLength; i++)
        {
            Console.WriteLine(currString);
        }
    }
}

