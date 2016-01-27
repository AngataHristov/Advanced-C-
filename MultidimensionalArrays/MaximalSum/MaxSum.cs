//Problem 2. Maximal sum
//
//Write a program that reads a rectangular matrix of size N x M and finds in
//it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter the rows of the matrix: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the columns of the matrix: ");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];

        if (N < 3 || M < 3)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("Matrix [{0},{1}]: ", row, col);
                    int member = int.Parse(Console.ReadLine());
                    matrix[row, col] = member;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine("max sum is: {0}", maxSum);
            Console.WriteLine("max row is: {0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
            Console.WriteLine("max column is: {0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
            Console.WriteLine("max column is: {0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
            Console.WriteLine();
        }

    }
}
