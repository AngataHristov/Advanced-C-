// Problem 7. Replace sub-string
// 
// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files(e.g. 100 MB).

using System;
using System.IO;

class ReplaceString
{
    static void Main()
    {
        string start = "..\\..\\start.txt";
        string finish = "..\\..\\finish.txt";
        StreamReader reader = new StreamReader(start);
        StreamWriter writer = new StreamWriter(finish);
        string currentLine = reader.ReadLine();
        using (writer)
        {
            using (reader)
            {
                while (currentLine != null)
                {
                    writer.WriteLine(currentLine.Replace("start", "finish"));
                    currentLine = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}
