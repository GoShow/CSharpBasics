using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the 
//variable values before and after the exchange.
class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Value of a = {0}\nValue of b = {1}",a,b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("Exchanged values\nValue of a = {0}\nValue of b = {1}", a, b);
    }
}
