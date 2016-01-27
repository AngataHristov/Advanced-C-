//Problem 8. Extract sentence.
//Write a program that extracts from a given text all sentences containing given word

using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter a word for searching: ");
        string keyWord = Console.ReadLine();
        string textPath = "..\\..\\text.txt";
        StreamReader reader = new StreamReader(textPath);
        string currentLine = reader.ReadToEnd();
        using (reader)
        {
            string[] sentences = currentLine.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nSentences containing word [{0}]:\n", keyWord);

            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsSentenceContainsWord(sentences, i, keyWord))
                {
                    Console.WriteLine(sentences[i].Trim() + '.');
                }

            }
        }
    }
    public static bool IsSentenceContainsWord(string[] sentences, int index, string word)
    {
        return Regex.Matches(sentences[index], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;
    }
}
