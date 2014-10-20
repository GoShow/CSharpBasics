using System;
using System.Text;
//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00a9';
        Console.WriteLine("  {0}\n {0}{0}{0}\n{0}{0}{0}{0}{0}",copyRight);
    }
}

