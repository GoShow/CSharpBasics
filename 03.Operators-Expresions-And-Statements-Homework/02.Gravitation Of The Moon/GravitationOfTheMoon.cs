using System;

class GravitationOfTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight in kg: ");
        double weight = int.Parse(Console.ReadLine());

        double weightOnMoon = weight * 17 / 100;
        Console.Write("On the Moon your weight will be: {0} kg", weightOnMoon);
        Console.WriteLine();
    }
}
