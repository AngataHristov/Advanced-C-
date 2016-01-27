// Problem 1. Odd lines
// 
// Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Globalization;

class OddLines
{
    static void Main()
    {
        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string inputPath = "C:\\Users\\ani\\Desktop\\Desktop files\\New Text Document.txt";
            StreamReader reader = new StreamReader(inputPath, Encoding.UTF8);

            using (reader)
            {
                int numberOfLine = 1;
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    if (numberOfLine % 2 != 0)
                    {
                        Console.WriteLine("{0}.{1}", numberOfLine, currentLine);
                    }
                    numberOfLine++;
                    currentLine = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex);
        }
        Console.WriteLine();
    }
}

