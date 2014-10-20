using System;

class VolleyBall
{
    static void Main()
    {
        string input = Console.ReadLine();
        double p = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double result = h + (48 - h) * 3 / 4 + p * 2 / 3;
        if (input == "leap")
        {
            result =(double)(result + (result * 15 / 100));
        }
        Console.WriteLine((int)result);
    }

}

