// Problem 6. Save sorted names
// 
// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        string filePath = "..\\..\\input.txt";
        string output = "..\\..\\output.txt";
        StreamReader reader = new StreamReader(filePath);
        List<string> text = new List<string>();
        using (reader)
        {
            string input = reader.ReadLine();
            while (input != null)
            {
                text.Add(input);
                input = reader.ReadLine();
            }
        }
        text.Sort();
        string[] sortedText = new string[text.Count];
        for (int i = 0; i < text.Count; i++)
        {
            sortedText[i] = text[i];
        }
        StreamWriter writer = new StreamWriter(output);
        using (writer)
        {
            for (int i = 0; i < sortedText.Length; i++)
            {
                writer.WriteLine(sortedText[i]);
            }
        }
        Console.WriteLine("Done!");
    }
}
