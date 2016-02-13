//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal,
//exe and prints them on the console on a single line, separated by comma and space.
//Use spaces, commas, dots, question marks and exclamation marks as word delimiters.
//Print only unique palindromes, sorted lexicographically.

namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PalindromesMain
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ',', '?', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            SortedSet<string> result = new SortedSet<string>();

            foreach (string word in words)
            {
                if (IsPolindrome(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        private static bool IsPolindrome(string word)
        {
            bool result = true;

            if (word.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
