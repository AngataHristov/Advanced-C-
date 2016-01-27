// Problem 10. Extract text from XML
// 
// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        string start = "..\\..\\text.txt";
        StreamReader reader = new StreamReader(start);
        int symbol = reader.Read();
        using (reader)
        {
            while (symbol != -1)
            {
                if (symbol == '>' || symbol == '<')
                {
                    Console.Write(" ");
                }
                if (symbol != '>' && symbol != '<' && symbol != '\n' && symbol != '\r' && symbol != '/')
                {

                    Console.Write((char)symbol);

                }
                symbol = reader.Read();
            }
            Console.WriteLine();
        }
    }
}
