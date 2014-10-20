using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that takes as input two lists of names and removes from the first list all names given
//in the second list. The input and output lists are given as words, separated by a space, each list at
//a separate line
class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter first list of names: ");
        string firstInput = Console.ReadLine();
        Console.WriteLine();
        List<string> firstListNames = firstInput.Split().ToList();
        Console.WriteLine("Enter second list of names: ");
        string secondInput = Console.ReadLine();
        Console.WriteLine();
        List<string> secondListNames = secondInput.Split().ToList();

        for (int i = 0; i < secondListNames.Count; i++)
        {
            for (int j = 0; j < firstListNames.Count; j++)
            {
                if (firstListNames[j] == secondListNames[i])
                {
                    firstListNames.Remove(firstListNames[j]);
                    j--;
                }
            }
        }

        Console.WriteLine("List with removed names: ");
        foreach (var name in firstListNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
        
    }
}

