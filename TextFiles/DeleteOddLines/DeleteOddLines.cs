// Problem 9. Delete odd lines
// 
// Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        string start = "..\\..\\input.txt";
        StreamReader reader = new StreamReader(start);
        string currentLine = reader.ReadLine();
        List<string> archive = new List<string>();
        int line = 1;
        using (reader)
        {
            while (currentLine != null)
            {
                if (line % 2 == 0)
                {
                    archive.Add(currentLine);
                }
                line++;
                currentLine = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(start);
        using (writer)
        {
            for (int i = 0; i < archive.Count; i++)
            {
                writer.WriteLine(archive[i]);
            }
        }
        Console.WriteLine("Done!");
    }
}
