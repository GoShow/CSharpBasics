using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[3, 6];
        Console.Write(' ');
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(' ');
        Console.Write(new string(' ', n - 1));


        Console.Write(' ');
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(' ');
        Console.WriteLine();
        for (int i = 0; i < n - 2; i++)
        {
            if (i == n / 2 - 1 )
            {
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.Write(new string('-', n - 1));
            
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.WriteLine();
            }

            else
            {
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.Write(new string(' ', n - 1));

                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.WriteLine();
            }
            
        }

        Console.Write(' ');
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(' ');
        Console.Write(new string(' ', n - 1));


        Console.Write(' ');
        Console.Write(new string('*', 2 * n - 2));
        Console.Write(' ');
        Console.WriteLine();
    }
}

