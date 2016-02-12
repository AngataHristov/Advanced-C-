namespace CollectTheCoins
{
    using System;

    public class CollectTheCoinsMain
    {
        private static int coinsCounter = new int();
        private static int wallsHitCounter = new int();

        public static void Main()
        {
            int rows = 4;
            int currentRow = 0;
            int currentCol = 0;
            string[][] board = FillBoard(rows);

            string movementCommands = Console.ReadLine();

            string currentCell = board[currentRow][currentCol];

            MoveOnBoard(movementCommands, currentCell, currentRow, rows, currentCol, board);

            Console.WriteLine("Coins collected: {0}", coinsCounter);
            Console.WriteLine("Walls hit: {0}", wallsHitCounter);
        }

        private static void MoveOnBoard(
                                        string movementCommands,
                                        string currentCell,
                                        int currentRow,
                                        int rows,
                                        int currentCol,
                                        string[][] board)
        {
            for (int i = 0; i < movementCommands.Length; i++)
            {
                char currentCommand = movementCommands[i];

                CheckForCoin(currentCell);

                switch (currentCommand)
                {
                    case 'V':
                        if (currentRow < rows - 1 && currentCol < board[currentRow + 1].Length)
                        {
                            currentRow++;
                            currentCell = board[currentRow][currentCol];
                        }
                        else
                        {
                            wallsHitCounter++;
                        }

                        break;
                    case '>':
                        if (currentCol < board[currentRow].Length - 1)
                        {
                            currentCol++;
                            currentCell = board[currentRow][currentCol];
                        }
                        else
                        {
                            wallsHitCounter++;
                        }

                        break;
                    case '<':
                        if (currentCol > 0)
                        {
                            currentCol--;
                            currentCell = board[currentRow][currentCol];
                        }
                        else
                        {
                            wallsHitCounter++;
                        }

                        break;
                    case '^':
                        if (currentRow > 0 && currentCol < board[currentRow - 1].Length)
                        {
                            currentRow--;
                            currentCell = board[currentRow][currentCol];
                        }
                        else
                        {
                            wallsHitCounter++;
                        }

                        break;
                }
            }
        }

        private static string[][] FillBoard(int rows)
        {
            string[][] board = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string currentLine = Console.ReadLine();

                board[row] = new string[currentLine.Length];

                for (int col = 0; col < currentLine.Length; col++)
                {
                    board[row][col] = currentLine[col].ToString();
                }
            }

            return board;
        }

        private static void CheckForCoin(string currentCell)
        {
            if (currentCell == "$")
            {
                coinsCounter++;
            }
        }
    }
}
