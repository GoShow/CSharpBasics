using System;
using System.Collections.Generic;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        List<string> hayvanNumbers = new List<string>();
        int abc = 0;
        int def = 0;
        int ghi = 0;

        for (int i = 999; i >= 555; i--)
        {
            ghi = i;
            def = ghi - diff;
            abc = def - diff;
            
            if (abc < 555)
            {
                break;
            }
            string numberAsString = abc.ToString() + def + ghi;
            if (
                numberAsString.Contains("0") ||
                numberAsString.Contains("1") ||
                numberAsString.Contains("2") ||
                numberAsString.Contains("3") ||
                numberAsString.Contains("4")
               )
            {
                continue;
            }
            else
            {
                int targetSum = 0;
                for (int j = 0; j < 9; j++)
                {
                    targetSum += Convert.ToInt32(numberAsString[j].ToString());
                }
                if (targetSum == sum)
                {
                    hayvanNumbers.Add(numberAsString);
                    
                }
            }
        }

        hayvanNumbers.Reverse();

        for (int i = 0; i < hayvanNumbers.Count; i++)
        {
            Console.WriteLine(hayvanNumbers[i]);
        }

        if (hayvanNumbers.Count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
