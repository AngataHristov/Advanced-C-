namespace MatrixShuffling
{
    using System;
    using System.Linq;

    public class MatrixShufflingMain
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = FillMatrix(rows, cols);

            PrintMatrix(matrix);

            string input = Console.ReadLine();

            ProcessTask(rows, cols, matrix, input);

            Console.WriteLine();
        }

        private static void ProcessTask(int rows, int cols, string[,] matrix, string input)
        {
            while (input != "END")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] inputArgs = input.Split();
                string command = inputArgs[0];

                if (command != "swap")
                {
                    Console.WriteLine("Invalid Input!");
                    input = Console.ReadLine();

                    continue;
                }

                int[] parameters = inputArgs.Skip(1).Select(int.Parse).ToArray();

                bool arePositionsInvalid = parameters[0] >= rows ||
                                           parameters[2] >= rows ||
                                           parameters[1] >= cols ||
                                           parameters[3] >= cols;

                if (arePositionsInvalid)
                {
                    Console.WriteLine("Invalid Input!");
                    input = Console.ReadLine();

                    continue;
                }

                Swap(matrix, parameters);

                input = Console.ReadLine();

                PrintMatrix(matrix);

                Console.WriteLine();
            }
        }

        private static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string currentInput = Console.ReadLine();

                    matrix[row, col] = currentInput;
                }
            }

            return matrix;
        }

        private static void Swap(string[,] matrix, int[] parameters)
        {
            string firstElement = matrix[parameters[0], parameters[1]];
            string secondElement = matrix[parameters[2], parameters[3]];

            matrix[parameters[0], parameters[1]] = secondElement;
            matrix[parameters[2], parameters[3]] = firstElement;
        }

        private static void PrintMatrix(string[,] matrix)
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
