// Problem 3. Line numbers
// 
// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string filePath = "C:\\Users\\ani\\Desktop\\Keys.ini";
        StreamReader reader = new StreamReader(filePath);
        StreamWriter writer = new StreamWriter("..\\..\\result.txt");
        using (reader)
        {
            using (writer)
            {
                string text = reader.ReadLine();
                int counter = 1;
                while (text != null)
                {
                    writer.WriteLine("{0:D2}.{1}", counter, text);
                    text = reader.ReadLine();
                    counter++;
                }
            }
        }
        Console.WriteLine("Done!");
    }
}
