using System;

class Volleyball
{
    static void Main()
    {   
        const double totalWeekends = 48;
        string year = Console.ReadLine();
        double p = int.Parse(Console.ReadLine());
        double h = int.Parse(Console.ReadLine());
        double normalWeekends = (totalWeekends - h) * 3 / 4;
        double holidays = p * 2 / 3;
        double totalPlays = h + normalWeekends + holidays;

        if (year == "leap")
        {
            totalPlays += totalPlays * 15 / 100;
        }

        Console.WriteLine((int)totalPlays);
    }
}

