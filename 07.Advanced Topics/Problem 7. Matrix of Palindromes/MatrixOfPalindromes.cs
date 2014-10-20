using System;

//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns
class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int width = int.Parse(Console.ReadLine());
        int nextChar = (char)('a');
        
        string[,] matrix = new string[height, width];
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] =
                    "" + (char)(nextChar) + (char)(nextChar + col) + (char)(nextChar );
            }
            nextChar++;
        }

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        ;
    }
}
