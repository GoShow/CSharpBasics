using System;
using System.Globalization;

//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
class DifferenceBetweenDates
{
    static void Main()
    {
        

        Console.Write("Enter first date: ");
        string first = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(first, "d.MM.yyyy", CultureInfo.CurrentCulture);
        Console.Write("Enter second date: ");
        string second = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(second, "d.MM.yyyy", CultureInfo.CurrentCulture);
        
        Console.WriteLine("Days between: " + CountDays(firstDate, secondDate));
    }

    static int CountDays(DateTime start, DateTime end)
    {
        TimeSpan span = end - start;
        int result = (int)span.TotalDays;

        return result;
    }
}

