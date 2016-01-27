// Problem 11. Prefix "test"
// 
// Write a program that deletes from a text file all words that start with the prefix test.
// Words contain only the symbols 0…9, a…z, A…Z, _

using System;
using System.IO;
using System.Text.RegularExpressions;
class PrefixTest
{
    static void Main()
    {
        string input = "..\\..\\input.txt";
        string output = "..\\..\\output.txt";
        StreamReader reader = new StreamReader(input);
        StreamWriter writer = new StreamWriter(output);
        string currentLine = reader.ReadLine();
        //string holder = "test";
        using (writer)
        {
            using (reader)
            {
                while (currentLine != null)
                {
                    //Regex rgx = new Regex(holder);
                    currentLine = Regex.Replace(currentLine,"test"," ");
                    writer.WriteLine(currentLine);
                    Console.WriteLine(currentLine);
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}
