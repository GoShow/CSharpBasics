using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double allWeekends = 48;
        double normalWeekends = (allWeekends - h) * 3 / 4;
        double holidays = p * 2 / 3;
        double result = h + normalWeekends + holidays;

        if (year == "leap")
        {
            result += result * 15 / 100;
        }
        Console.WriteLine((int)result);
    }
}

