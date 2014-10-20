using System;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score between 1 and 9: ");
        int score = int.Parse(Console.ReadLine());
        int bonusScore = 0;

        if (score >= 1 && score <= 3)
        {
            bonusScore = score * 10;
        }
        else if (score >= 4 && score <= 6)
        {
            bonusScore = score * 100;
        }

        else if (score >= 7 && score <= 9)
	    {
            bonusScore = score * 1000;
    	}
        
        else
        {
            Console.WriteLine("Invalid score!");
            return;
        }

        Console.WriteLine("Bonus score: {0}", bonusScore);
    }
}

