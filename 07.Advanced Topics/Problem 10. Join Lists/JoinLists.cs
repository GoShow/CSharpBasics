using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first
//list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and 
//output lists are given as integers, separated by a space, each list at a separate line. 

class JoinLists
{
    static void Main()
    {
        string firstNumbersString = Console.ReadLine();
        List<string> firstNumbers = firstNumbersString.Split().ToList();
        string secondNumbersString = Console.ReadLine();
        List<string> secondNumbers = secondNumbersString.Split().ToList();
        List<string> finalNumbersSequence = new List<string>();

        for (int i = 0; i < firstNumbers.Count; i++)
        {
            finalNumbersSequence.Add(firstNumbers[i]);
        }

        for (int i = 0; i < secondNumbers.Count; i++)
        {
            finalNumbersSequence.Add(secondNumbers[i]);
        }

        finalNumbersSequence.Sort();

        for (int i = 0; i < finalNumbersSequence.Count - 1; i++)
        {
            if (finalNumbersSequence[i] == finalNumbersSequence[i + 1])
            {
                finalNumbersSequence.Remove(finalNumbersSequence[i]);
                i--;
            }
        }

        for (int i = 0; i < finalNumbersSequence.Count; i++)
        {
            Console.Write(finalNumbersSequence[i] + " ");
        }
    }
}

