using System;

//Which of the following values can be assigned to a variable of type float and which to a variable of type 
//double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them
//to ensure no precision is lost.

class FloatOrDouble
{
    static void Main()
    {
        double a = 34.567839023d;
        float b = 12.345f;
        double c = 8923.1234857d;
        float d = 3456.091f;
        Console.WriteLine("These two variables are double type: {0} and {1}\nThese two variables are float type: {2} and {3}", a, c, b, d);  
    }
}

