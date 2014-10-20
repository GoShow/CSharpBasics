using System;
using System.Collections.Generic;

//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters 
//should be listed in alphabetical order. Use the input and output format from the examples below. 
class CountOfLetters
{
    static void Main()
    {
        Console.Write("Enter letters separated by intervals: ");
        string input = Console.ReadLine();

        string[] letters = input.Split();
        Array.Sort(letters);
        int count = 1;
        string currLetter = letters[0];

        for (int i = 0; i < letters.Length - 1 ; i++)
        {
            if (i == letters.Length - 2 && letters[i] == letters[i + 1]) // if last letter in array is the same as previous
            {
                count++;
                Console.WriteLine(currLetter + " -> " + count);
                break;
            }

            if (letters[i] == letters[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine(currLetter + " -> " + count);
                count = 1;
                currLetter = letters[i + 1];
            }
        }

        //if last letter is different
        if (letters[letters.Length - 1] != letters[letters.Length - 2])
        {
            Console.WriteLine(letters[letters.Length - 1] + " -> " + 1);
        }
    }
}

