using System;
using System.Collections.Generic;
class ExtractUrl
{
    static void Main()
    {
        List<string> urls = new List<string>();
        Console.WriteLine("Enter some text with URLs: ");
        string input = Console.ReadLine();
        string[] words = input.Split();
        foreach (var word in words)
        {
            if (word.Contains("http://") || word.Contains("www."))
            {
                urls.Add(word);
            }
        }

        Console.WriteLine();
        Console.WriteLine("List of URLs in text:");
        Console.WriteLine();

        foreach (var url in urls)
        {
            Console.WriteLine(url);
        }
    }
}

