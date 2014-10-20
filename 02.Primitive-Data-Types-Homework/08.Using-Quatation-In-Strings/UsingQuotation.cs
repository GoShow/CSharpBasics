using System;

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their 
//value was correctly defined.

class UsingQuotation
{
    static void Main()
    {
        string firstString = "The \"use\" of quotations causes difficulties.";
        string secondString = @"The ""use"" of quotations causes difficulties.";
;
        Console.WriteLine("{0}\n{1}",firstString,secondString);
    }
}

