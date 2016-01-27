// Problem 5. Maximal area sum
// 
// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.IO;

class MaximalAreaSum
{
    public static void FindMaxSumInMatrix(int[,] matrix)
    {
        int maxSum = int.MinValue;
        int currentSum = new int();
        int maxRow = new int();
        int maxCol = new int();
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRow = row;
                    maxCol = col;
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine("The max sum is: " + maxSum);
        Console.WriteLine("The max numbers are:");
        Console.WriteLine("{0} {1}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1]);
        Console.WriteLine("{0} {1}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1]);
        Console.WriteLine();
    }
    public static void Main()
    {
        string path = "..\\..\\matrix.txt";
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            string firstLine = reader.ReadLine();
            int matrixSize = int.Parse(firstLine);
            int[,] matrix = new int[matrixSize, matrixSize];
            string currentLine = reader.ReadLine();

            while (currentLine != null)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string[] text = currentLine.Split(' ');
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(text[col]);
                    }
                    currentLine = reader.ReadLine();
                }
            }
            FindMaxSumInMatrix(matrix);
        }
    }
}
