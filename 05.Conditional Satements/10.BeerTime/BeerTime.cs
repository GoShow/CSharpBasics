

using System;
using System.Globalization;
using System.Threading;

//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range 
//[01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the
//definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and 
//times. 
class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime time;
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        Console.Write("Enter time (hour(1 - 12):minutes(0-59) AM/PM: ");
        string timeAsString = Console.ReadLine();

        if (DateTime.TryParseExact(timeAsString, "h:mm tt", enUS,
                                    DateTimeStyles.None, out time))
        {
            if (time > startTime || time < endTime)
            {
                Console.WriteLine("Beer time :) ");
            }
            else
            {
                Console.WriteLine("Non-beer time :( ");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

