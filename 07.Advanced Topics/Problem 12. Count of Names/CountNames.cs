using System;

//Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should 
//be listed in alphabetical order. Use the input and output format from the examples below. 
class CountNames
{
    static void Main()
    {
        Console.Write("Enter names separated by intervals: ");
        string input = Console.ReadLine();

        string[] names = input.Split();
        Array.Sort(names);
        int count = 1;
        string currName = names[0];

        for (int i = 0; i < names.Length - 1; i++)
        {
            if (i == names.Length - 2 && names[i] == names[i + 1]) // if last name in array is the same as previous
            {
                count++;
                Console.WriteLine(currName + " -> " + count);
                break;
            }

            if (names[i] == names[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine(currName + " -> " + count);
                count = 1;
                currName = names[i + 1];
            }
        }

        //if last name is different
        if (names[names.Length - 1] != names[names.Length - 2])
        {
            Console.WriteLine(names[names.Length - 1] + " -> " + 1);
        }
    }
}

