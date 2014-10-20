using System;

class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc = 0;
        int def = 0;
        int ghi = 0;
        bool isNumber = false;

        for (int i = 555; i <= 999; i++)
        {
            abc = i;
            def = abc + diff;
            ghi = def + diff;

            if (ghi > 999)
            {
                break;
            }

            string wholeNum = "" + abc + def + ghi;

            if (wholeNum.Contains("1") || wholeNum.Contains("2") || wholeNum.Contains("3") || wholeNum.Contains("4") || wholeNum.Contains("0"))
            {
                continue;
            }

            if (sum == CalcSum(wholeNum))
            {
                Console.WriteLine(wholeNum);
                isNumber = true;
            }
        }

        if (!isNumber)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcSum(string wholeNum)
    {
        int targetSum = 0;
        for (int k = 0; k < wholeNum.Length; k++)
        {
            targetSum += Convert.ToInt32(wholeNum[k].ToString());
        }
        return targetSum;
    }

}

