using System;

class DateAfterTenYears
{
    static void Main()
    {
        //This was my first solution.It's also working but the algorithm is not right. :)

        //Console.Write("Enter your age : ");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine("After 10 years you will be {0} years old.", age + 10);

        //Second (right) solution :)

        Console.Write("Please enter your birthday (YYYY-MM-DD) : ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int afterTenYears = (DateTime.Now.Year - birthday.Year) + 10;
        Console.WriteLine("After 10 years you will be {0}.", afterTenYears);

    }
}

