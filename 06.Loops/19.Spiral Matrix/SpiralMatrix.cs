using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        string direction = "right";
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;

        for (int i = 1; i <= n * n; i++)
        {
            matrix[row, col] = i;

            if ((direction == "right" && col == n - 1) || (direction == "right" && (matrix[row, col + 1] != 0)))
            {
                direction = "down";
            }
            
            else if ((direction == "left" && col == 0) || (direction == "left" && (matrix[row, col - 1] != 0)))
            {
                direction = "up";
            }

            else if ((direction == "up" && row == 0) || (direction == "up" && (matrix[row - 1, col] != 0)))
            {
                direction = "right";
            }

            else if ((direction == "down" && row == n - 1) || (direction == "down" && (matrix[row + 1, col] != 0)))
            {
                direction = "left";
            }

            switch (direction)
            {
                case "right":
                    col++;
                    break;
                case "left":
                    col--;
                    break;
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix.GetLength(0) < 10)   // this if - else statements are for aligning matrix (number of whitespaces)
                {

                    if (matrix[row, col] < 10)
                    {
                        Console.Write(matrix[row, col] + "  ");
                    }

                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                else
                {
                    if (matrix[row, col] < 10)
                    {
                        Console.Write(matrix[row, col] + "   ");
                    }

                    else if (matrix[row, col] >= 10 && (matrix[row, col] < 100))
                    {
                        Console.Write(matrix[row, col] + "  ");
                    }

                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
