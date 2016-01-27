// Problem 9. Forbidden words
// 
// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter list of words, splitted by space: ");
        string list = Console.ReadLine();
        string textPath = "..\\..\\text.txt";
        StreamReader reader = new StreamReader(textPath);
        string[] wordsList = list.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string input = reader.ReadToEnd();
        string[] text = input.Split('.');
        using (reader)
        {
            for (int i = 0; i < text.Length; i++)
            {
                string[] words = text[i].Split(' ');

                for (int j = 0; j < words.Length; j++)
                {
                    for (int k = 0; k < wordsList.Length; k++)
                    {
                        if (words[j] == wordsList[k])
                        {
                            input = input.Replace(wordsList[k], new string('*', wordsList[k].Length));
                        }
                    }
                }
            }
            Console.Write(input);
            Console.WriteLine();
        }
    }
}
