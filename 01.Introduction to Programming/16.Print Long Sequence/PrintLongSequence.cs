using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {

            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }
            else
            {
                if (i == 1001)  //this "if" is for not putting "," after the last number of the sequence
                {
                    Console.WriteLine(-i);
                    break;
                }
                Console.Write(-i + ",");
            }
        }
    }
}


