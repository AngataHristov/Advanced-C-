// Write a program that reads a rectangular integer matrix of size N x M and finds in
// it the square 3 x 3 that has maximal sum of its elements. 
// On the first line, you will receive the rows N and columns M.
// On the next N lines you will receive each row with its columns.
// Print the elements of the 3 x 3 square as a matrix, along with their sum.

namespace MaximalSum
{
    using System;
    using System.Linq;

    public class MaximalSumMain
    {
        public static void Main()
        {
            Console.Write("Enter the size of the matrix NxM: ");

            int[] sizes = Console.ReadLine()
                    .Split(new char[] { ' ', ',', 'x' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = FillMatrix(rows, cols);

            PrintMatrix(matrix);

            Console.WriteLine();

            int[,] maxSumMatrix = FindSubMatrixWithMaxSum(matrix);
            int maxSum = FindSum(maxSumMatrix);

            Console.WriteLine("The max sum is: {0}", maxSum);

            Console.WriteLine();

            PrintMatrix(maxSumMatrix);

            Console.WriteLine();
        }

        private static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                Console.Write("Enter the {0}-th row: ", row);

                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ', ',', 'x' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                if (currentRow.Length < rows)
                {
                    throw new InvalidOperationException(string.Format("The number of the members in each row should be {0}", cols));
                }

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            return matrix;
        }

        public static int[,] FindSubMatrixWithMaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int maxRow = new int();
            int maxCol = new int();

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            int[,] subMatrix =
            {
                {matrix[maxRow, maxCol] , matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2] },
                {matrix[maxRow + 1, maxCol] , matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2] },
                {matrix[maxRow + 2, maxCol] , matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2] }
            };

            return subMatrix;
        }

        private static int FindSum(int[,] matrix)
        {
            int sum = new int();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
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
