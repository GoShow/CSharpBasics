using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {

        Console.WriteLine("Enter report line by line.To see the result type \"end\".");
        string line = null;
        Dictionary<string, double> sites = new Dictionary<string, double>();
        Dictionary<string, int> counters = new Dictionary<string, int>();
        int counter = 1;
        while (true)
        {
            Console.WriteLine("Enter line: ");
            line = Console.ReadLine();
            if (line == "end")
            {
                break;
            }
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3]);

            if (!sites.Keys.Contains(link))
            {
                sites[link] = loadTime;
                counters.Add(link, 1);
            }
            else
            {
                counters[link] += 1;
                sites[link] = sites[link] + loadTime;
            }
        }
        foreach (string link in sites.Keys)
        {
            Console.WriteLine("{0} = {1}", link, sites[link] / counters[link]);
        }

    }
}

