using System;

//Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. 
//The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. 
//Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a 
//sequence of letters separated by punctuation or start / end of text. 
class CountingWordinText
{
    static void Main()
    {
        Console.WriteLine("Enter a keyword:");
        string givenWord = Console.ReadLine();
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        foreach (char ch in text)
        {
            if (!((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')))
            {
                text = text.Replace(ch, ' ');
            }
        }
        string[] list = text.Split(' ');
        int keywordCounter = 0;
        foreach (string word in list)
        {
            if (word.ToLower() == givenWord.ToLower())
            {
                keywordCounter++;
            }
        }
        Console.WriteLine("\"{0}\" occurs {1} times in the text.", givenWord, keywordCounter);
    }
}

