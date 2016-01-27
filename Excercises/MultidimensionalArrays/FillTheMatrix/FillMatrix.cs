//Problem 1. Fill the matrix
//
//Write a program that fills and prints a matrix of size(n, n) as shown below:

using System;

class FillMatrix
{
    static void Main()
    {
        Console.Write("Enter the size nxn of the matrix: ");
        int Size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[Size, Size];


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + 1 + 4 * col;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //for (int col = 0; col < matrix.GetLength(1); col++)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        matrix[row, col] = 4 * row + 1 + col;
        //    }
        //}
        //for (int col = 0; col < matrix.GetLength(1); col++)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        Console.Write("{0,2} ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
