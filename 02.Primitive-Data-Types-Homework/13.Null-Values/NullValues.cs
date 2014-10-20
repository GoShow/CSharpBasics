using System;

class Program
{
    static void Main()
    {
        int? intNum = null;
        double? doubleNum = null;
        Console.WriteLine("Int number = {0}\nDouble number = {1}",intNum,doubleNum);
        intNum = intNum + 15;
        doubleNum = doubleNum + 20;
        Console.WriteLine("Int number = {0}\nDouble number = {1}", intNum, doubleNum);
        intNum = intNum + null;
        doubleNum = doubleNum + null;
        Console.WriteLine("Int number = {0}\nDouble number = {1}", intNum, doubleNum);
    }
}

