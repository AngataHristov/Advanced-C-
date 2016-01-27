
using System;
using System.Collections.Generic;
using System.Linq;

class MultiArr
{
    static void Main()
    {
        // int[] singleArr = new int[5];
        // int[,] doubleArr = new int[5, 4];
        // int[,,] tripleArr = new int[5, 4, 4];
        // doubleArr[2, 3] = 100;
        // int[,] matrix =
        //     {
        //     {1,2},
        //     {3,4},
        //     {5,6}
        //     };

        // int[,] numbers = new int[2, 2];
        // int rows = numbers.GetLength(0);
        // int cols = numbers.GetLength(1);
        // 
        // for (int row = 0; row < rows; row++)
        // {
        //     for (int col = 0; col < cols; col++)
        //     {
        //         int value = int.Parse(Console.ReadLine());
        //         numbers[row, col] = value;
        //     }
        // }
        // for (int row = 0; row < rows; row++)
        // {
        //     for (int col = 0; col < cols; col++)
        //     {
        //         Console.Write("{0} ",numbers[row, col]);
        //     }
        //     Console.WriteLine();
        // }

        // List<List<int>> numbersList = new List<List<int>>();
        // numbersList.Add(new List<int>());
        // numbersList[0].Add(1);

        //int[,] arr = new int[3, 4];
        //for (int row = 0; row < arr.GetLength(0); row++)
        //{
        //    for (int col = 0; col < arr.GetLength(1); col++)
        //    {
        //        arr[row, col] = row + col;
        //    }
        //}

        // Input and output for a matrix nxm.
        //
        // Console.Write("Enter number ot rows:");
        // int rows = int.Parse(Console.ReadLine());
        // 
        // Console.Write("Enter number ot cols:");
        // int cols = int.Parse(Console.ReadLine());
        // 
        // int[,] numbers = new int[rows, cols];
        // 
        // for (int row = 0; row < rows; row++)
        // {
        //     for (int col = 0; col < cols; col++)
        //     {
        //         Console.Write("Enter matrix [{0}, {1}]: ", row, col);
        //         numbers[row, col] = int.Parse(Console.ReadLine());
        //     }
        // }
        // Console.WriteLine("Your matrix is:");
        // for (int row = 0; row < rows; row++)
        // {
        //     for (int col = 0; col < cols; col++)
        //     {
        //         Console.Write("{0} ", numbers[row, col]);
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine();

        // string text = "1,2 3!4";
        // string[] textParts = text.Split(',');
        // Split()==Split(' ') - interval

        // string text = "1,2 3!4";
        // string[] textPartsTwo = text.Split(',', '!', ' ');

        // string text = "1,2 3!4    5";
        // string[] textPartsThree = text.Split(new char[] {',', '!', ' '}, StringSplitOptions.RemoveEmptyEntries);

        // Console.Write("Enter number ot rows:");
        // int rows = int.Parse(Console.ReadLine());
        // 
        // Console.Write("Enter number ot cols:");
        // int cols = int.Parse(Console.ReadLine());
        // 
        // int[,] numbers = new int[rows, cols];
        // 
        // for (int row = 0; row < rows; row++)
        // {
        //     Console.WriteLine("Enter the {0}-th row: ");
        //     string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //     if (currentRow.Length < numbers.GetLength(1))
        //     {
        //         Console.WriteLine("Error!");
        //         break;
        //     }
        //     for (int col = 0; col < numbers.GetLength(1); col++)
        //     {
        //         numbers[row, col] = int.Parse(currentRow[col]);
        //     }
        // }
        // Console.WriteLine("Your matrix is:");
        // for (int row = 0; row < rows; row++)
        // {
        //     for (int col = 0; col < cols; col++)
        //     {
        //         Console.Write("{0} ", numbers[row, col]);
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine();
    }
}
