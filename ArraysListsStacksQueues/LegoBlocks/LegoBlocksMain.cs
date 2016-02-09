//You are given two jagged arrays. Each array represents a Lego block containing integers.
//Your task is first to reverse the second jagged array and then check if it would 
//fit perfectly in the first jagged array.

namespace LegoBlocks
{
    using System;
    using System.Linq;

    public class LegoBlocksMain
    {
        public static void Main()
        {
            // Console.Write("Enter the number of arrays: ");

            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] firstJaggedArray = new int[numberOfRows][];
            int[][] secondJaggedArray = new int[numberOfRows][];

            FillArray(numberOfRows, firstJaggedArray);
            FillArray(numberOfRows, secondJaggedArray);

            for (int row = 0; row < numberOfRows; row++)
            {
                Array.Reverse(secondJaggedArray[row]);
            }

            bool areFit = true;
            int numberOfCells = new int();

            areFit = CheckForFitting(numberOfRows, firstJaggedArray, secondJaggedArray, areFit);

            if (areFit)
            {
                PrintArray(numberOfRows, firstJaggedArray, secondJaggedArray);
            }
            else
            {
                numberOfCells = CalculateNumberOfCells(numberOfRows, firstJaggedArray, secondJaggedArray);

                Console.WriteLine("The total number of cells is: {0}", numberOfCells);
            }

        }

        private static void FillArray(int numberOfRows, int[][] jaggedArray)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = new int[currentRow.Length];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    jaggedArray[row][col] = currentRow[col];
                }
            }
        }

        private static bool CheckForFitting(int numberOfRows, int[][] firstJaggedArray, int[][] secondJaggedArray, bool areFit)
        {
            int firtsRowsTotalLengt = firstJaggedArray[0].Length + secondJaggedArray[0].Length;

            for (int row = 1; row < numberOfRows; row++)
            {
                int rowsTotalLengt = firstJaggedArray[row].Length + secondJaggedArray[row].Length;

                if (firtsRowsTotalLengt != rowsTotalLengt)
                {
                    areFit = false;
                    break;
                }
            }

            return areFit;
        }

        private static int CalculateNumberOfCells(int numberOfRows, int[][] firstJaggedArray, int[][] secondJaggedArray)
        {
            int numberOfCells = 0;

            for (int row = 0; row < numberOfRows; row++)
            {
                numberOfCells += firstJaggedArray[row].Length + secondJaggedArray[row].Length;
            }

            return numberOfCells;
        }

        private static void PrintArray(int numberOfRows, int[][] firstJaggedArray, int[][] secondJaggedArray)
        {
            for (int row = 0; row < numberOfRows; row++)
            {

                string currenRow = string.Join(", ", firstJaggedArray[row]) + ", " + string.Join(", ", secondJaggedArray[row]);

                string result = string.Format("[{0}]", currenRow);

                Console.WriteLine(result);
            }
        }
    }
}
