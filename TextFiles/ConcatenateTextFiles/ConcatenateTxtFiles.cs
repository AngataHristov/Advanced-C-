// Problem 2. Concatenate text files
// 
// Write a program that concatenates two text files into another text file.

using System;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Text;

class ConcatenateTxtFiles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string inputPathOne = "..\\..\\Text1.txt";
        string inputPathTwo = "..\\..\\Text2.txt";
        string result = "..\\..\\Result.txt";

        StreamWriter writer = new StreamWriter(result);
        using (writer)
        {
            StreamReader readerOne = new StreamReader(inputPathOne);
            using (readerOne)
            {
                string textOne = readerOne.ReadLine();
                while (textOne != null)
                {
                    writer.Write(textOne);
                    textOne = readerOne.ReadLine();
                }
            }
            StreamReader readerTwo = new StreamReader(inputPathTwo);
            using (readerTwo)
            {
                string textTwo = readerTwo.ReadLine();
                while (textTwo != null)
                {
                    writer.Write(textTwo);
                    textTwo = readerTwo.ReadLine();
                }
            }
        }

        Console.WriteLine("Just finished!");
    }
}
