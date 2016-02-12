//We are given a matrix of strings of size N x M. Sequences in the matrix we define
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix. 

namespace SequenceInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SequenceInMatrixMain
    {
        private static string[,] matrix;
        private static string currentString = string.Empty;

        public static void Main()
        {
            Console.Write("Enter the size of the matrix NxM: ");

            int[] sizes = Console.ReadLine()
                    .Split(new char[] { ' ', ',', 'x' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            matrix = new string[rows, cols];

            FillMatrix(rows, cols);

            LongestSequence();
        }

        private static void FillMatrix(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string currentInput = Console.ReadLine();

                    matrix[row, col] = currentInput;
                }
            }
        }

        private static void LongestSequence()
        {
            int longestSeq = 0;
            string maxRepeatable = String.Empty;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    currentString = matrix[i, j];

                    int rowCount = CountRow(i, j);
                    int colCount = CountCol(i, j);
                    int diagCount = CountDiagonal(i, j);
                    int temp = Math.Max(Math.Max(rowCount, colCount), diagCount);

                    if (temp > longestSeq)
                    {
                        longestSeq = temp;
                        maxRepeatable = currentString;
                    }
                }
            }

            PrintResult(longestSeq, maxRepeatable);
        }

        private static void PrintResult(int count, string word)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write("{0,4} ", matrix[a, b]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("longest sequence is:");

            for (int c = 0; c < count; c++)
            {
                Console.Write("{0}, ", word);
            }

            Console.WriteLine();
        }

        private static int CountRow(int i, int j)
        {
            int counter = 1;
            for (int a = j + 1; a < matrix.GetLength(1); a++)
            {
                if (matrix[i, a] == currentString)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static int CountCol(int i, int j)
        {
            int counter = 1;
            for (int a = i + 1; a < matrix.GetLength(0); a++)
            {
                if (matrix[a, j] == currentString)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static int CountDiagonal(int i, int j)
        {
            int counter = 1;
            int diagonal = (matrix.GetLength(0) < matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);
            for (int a = j + 1; a < diagonal; a++)
            {
                if (matrix[a, a] == currentString)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
