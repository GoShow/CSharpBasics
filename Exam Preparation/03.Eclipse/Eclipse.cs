using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // top - left
        Console.Write(" ");
        Console.Write(new string('*', n * 2 - 2));
        Console.Write(" ");
        
        //top - middle
        Console.Write(new string(' ', n - 1));

        //top - right
        Console.Write(" ");
        Console.Write(new string('*', n * 2 - 2));
        Console.Write(" ");
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*");
            Console.Write(new string('/', n * 2 - 2));
            Console.Write("*");

            if (i == n / 2 - 1)
            {
                Console.Write(new string('-', n - 1));
            }
            else
            {
                Console.Write(new string(' ', n - 1));

            }
            
            
            Console.Write("*");
            Console.Write(new string('/', n * 2 - 2));
            Console.Write("*");
            Console.WriteLine();
        }

        //bottom - left
        Console.Write(" ");
        Console.Write(new string('*', n * 2 - 2));
        Console.Write(" ");

        //bottom - middle
        Console.Write(new string(' ', n - 1));

        //bottom - right
        Console.Write(" ");
        Console.Write(new string('*', n * 2 - 2));
        Console.Write(" ");

    }
}

