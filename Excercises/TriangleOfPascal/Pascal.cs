using System;
using System.Collections.Generic;
using System.Linq;

class Pascal
{
    static void Main()
    {

        int height = 10;
        int[][] triangle = new int[height][];
        triangle[0] = new int[1];
        triangle[0][0] = 1;

        for (int row = 1; row < height; row++)
        {
            triangle[row] = new int[row + 1];
            triangle[row][0] = 1;

            for (int col = 1; col < row; col++)
            {
                triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }
            triangle[row][row] = 1;
        }
        int counter = 20;
        for (int row = 0; row < triangle.Length; row++)
        {
            Console.Write("".PadLeft(counter));
            for (int col = 0; col < row+1; col++)
            {
                Console.Write("{0,3} ", triangle[row][col]);
            }
            Console.WriteLine();
            counter -= 2;
        }
    }
}
