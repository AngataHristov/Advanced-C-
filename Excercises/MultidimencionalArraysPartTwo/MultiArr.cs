using System;
using System.Collections.Generic;
using System.Linq;

class MultiArr
{
    static void Main()
    {
        // Find a 2x2 platform int a matrix with a maximal sum of its elements.

        int[,] matrix = new int[3, 6]
            {
                {7,1,3,3,2,1},
                {1,3,9,8,5,6},
                {4,6,7,9,1,0}
            };
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        Console.WriteLine("Max sum is:{0}", maxSum);
        Console.WriteLine("{0} {1}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1]);
        Console.WriteLine("{0} {1}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1]);
    }
}
