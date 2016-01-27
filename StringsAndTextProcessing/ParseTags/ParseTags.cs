// Problem 5. Parse tags
// 
// You are given a text.Write a program that changes the text in all regions surrounded by the tags<upcase>
// and</upcase> to upper-case.The tags cannot be nested.
// We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

using System;
using System.Text.RegularExpressions;
using System.IO;

class ParseTags
{
    static void Main()
    {
        string textPath = "..\\..\\text.txt";
        StreamReader reader = new StreamReader(textPath);
        string currentLine = reader.ReadLine();

        using (reader)
        {
            while (currentLine != null)
            {
                currentLine = Regex.Replace(currentLine, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());
                Console.WriteLine(currentLine);
                currentLine = reader.ReadLine();
            }
        }
    }
}
