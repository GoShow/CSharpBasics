using System;

//Write a program to find the longest word in a text. 
class LongestWordInText
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();
        string trimInput = input.Trim('.');
        string[] words = trimInput.Split();
        int bestLength = 0;
        string longestWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            int wordLength = words[i].Length;
            if (bestLength < wordLength)
            {
                bestLength = wordLength;
                longestWord = words[i];
            }
        }
        Console.WriteLine("Longest word is: {0}", longestWord);
    }
}

