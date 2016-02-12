// Write a program that reads some text from the console and counts the occurrences
// of each character in it. Print the results in alphabetical (lexicographical) order. 

namespace CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbolsMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> countByUniqueChars = new SortedDictionary<char, int>();


            foreach (var symbol in input)
            {
                if (!countByUniqueChars.ContainsKey(symbol))
                {
                    countByUniqueChars[symbol] = 0;
                }

                countByUniqueChars[symbol]++;
            }

            PrintResult(countByUniqueChars);
        }

        private static void PrintResult(SortedDictionary<char, int> keyValuePairs)
        {
            foreach (KeyValuePair<char, int> pair in keyValuePairs)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}
