namespace TerroristsWin
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TerroristsWinMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<int> boundaries = new List<int>();
            List<string> bombs = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '|')
                {
                    boundaries.Add(i);
                }
            }

            for (int i = 0; i < boundaries.Count; i += 2)
            {
                bombs.Add(input.Substring(boundaries[i] + 1, boundaries[i + 1] - boundaries[i] - 1));
            }

            List<int> bombsPower = new List<int>();

            for (int i = 0; i < bombs.Count; i++)
            {
                int bombLettersSum = 0;

                foreach (var symbol in bombs[i])
                {
                    bombLettersSum += symbol;
                }

                int bombPower = bombLettersSum % 10;

                bombsPower.Add(bombPower);
            }

            StringBuilder result = new StringBuilder(input);
            int boundariesIndex = 0;

            for (int i = 0; i < bombs.Count; i++)
            {
                int boundariesLength = 2;
                int explosionRange = 2 * bombsPower[i] + bombs[i].Length + boundariesLength;
                string textForReplaceing = string.Empty;

                if (boundaries[boundariesIndex] - bombsPower[i] > 0)
                {
                    textForReplaceing = input.Substring(boundaries[boundariesIndex] - bombsPower[i], explosionRange);
                    result.Replace(textForReplaceing, new string('.', explosionRange));
                }
                else
                {
                    textForReplaceing = input.Substring(0, explosionRange - bombsPower[i]);
                    result.Replace(textForReplaceing, new string('.', explosionRange - bombsPower[i]));
                }

                boundariesIndex += 2;

            }

            Console.WriteLine(result.ToString());
        }
    }
}
