// Write two programs that fill and print a matrix of size N x N.
// Filling a matrix in the regular pattern (top to bottom and left to right) is boring. 

namespace FillTheMatrix
{
    using System;

    public class FillTheMatrixMain
    {
        public static void Main()
        {
            Console.Write("Enter the size of matrix NxN: ");

            int size = int.Parse(Console.ReadLine());

            int[,] matrix = FillMatrix(size);

            int[,] secondMatrix = FillSecondMatrix(size);

            PrintMatrix(matrix);

            Console.WriteLine();

            PrintMatrix(secondMatrix);
        }

        private static int[,] FillMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = row + 4 * col + 1;
                }
            }

            // int counter = 1;
            // for (int col = 0; col < matrix.GetLength(1); col++)
            // {
            //     for (int row = 0; row < matrix.GetLength(0); row++)
            //     {
            //         matrix[row, col] = counter;
            //         counter++;
            //     }
            // }

            return matrix;
        }

        private static int[,] FillSecondMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            int counter = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
