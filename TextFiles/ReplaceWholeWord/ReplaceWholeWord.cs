// Problem 8. Replace whole word
// 
// Modify the solution of the previous problem to replace only whole words(not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
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
                    writer.WriteLine(Regex.Replace(currentLine, "start", "finish"));
                    currentLine = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Done!");
    }
}
