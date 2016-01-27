// Problem 4. Sub-string in text
// 
// Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).

using System;
using System.Text;
using System.IO;

class SubstringInText
{
    static void Main()
    {
        string textPath = "..\\..\\text.txt";
        StreamReader reader = new StreamReader(textPath);
        string currentLine = reader.ReadLine();
        int counter = new int();
        string keyWord = "in";
        using (reader)
        {
            while (currentLine != null)
            {
                int index = new int();
                while (true)
                {
                    int found = currentLine.IndexOf(keyWord, index);
                    if (found < 0)
                    {
                        break;
                    }
                    if (found >= 0)
                    {
                        counter++;
                    }
                    index = found + 1;
                }
                currentLine = reader.ReadLine();
            }
        }
        Console.WriteLine("The word \"in\" contains {0} times in the text", counter);
    }
}
