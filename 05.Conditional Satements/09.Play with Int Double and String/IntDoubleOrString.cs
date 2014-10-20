using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or
//double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result
//at the console. Use switch statement. 
class IntDoubleOrString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1--> int");
        Console.WriteLine("2--> double");
        Console.WriteLine("3--> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Please enter an integer: ");
                int inputInt = int.Parse(Console.ReadLine());
                inputInt++;
                Console.WriteLine(inputInt);
                break;

            case "2":
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                inputDouble++;
                Console.WriteLine(inputDouble);
                break;

            case "3":
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString + "*");
                break;

            default:
                Console.WriteLine("Incorrect entry!");
                break;
        }

    }
}

