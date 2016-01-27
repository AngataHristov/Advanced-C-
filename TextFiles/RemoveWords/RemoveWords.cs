// Problem 12. Remove words
// 
// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class RemoveWords
{
    static void Main()
    {
        try
        {
            string text = "..\\..\\text.txt";
            string list = "..\\..\\ListOfWords.txt";
            StreamReader readerOne = new StreamReader(text);
            StreamReader readerTwo = new StreamReader(list);
            string currentLineText = readerOne.ReadLine();
            string currentLineList = readerTwo.ReadLine();
            List<string> ListOfWords = new List<string>();

            using (readerOne)
            {
                using (readerTwo)
                {
                    while (currentLineList != null)
                    {
                        ListOfWords.Add(currentLineList);
                        currentLineList = readerTwo.ReadLine();
                    }
                    while (currentLineText != null)
                    {
                        for (int i = 0; i < ListOfWords.Count; i++)
                        {
                            currentLineText = Regex.Replace(currentLineText, ListOfWords[i], string.Empty);
                        }
                        Console.WriteLine(currentLineText);
                        currentLineText = readerOne.ReadLine();
                    }
                }
            }
            Console.WriteLine("Done!");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (System.Security.SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
