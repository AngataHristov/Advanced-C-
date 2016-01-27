// Problem 4. Compare text files
// 
// Write a program that compares two text files line by line and prints the number of lines that are
// the same and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string inputPathOne = "..\\..\\Text1.txt";
        string inputPathTwo = "..\\..\\Text2.txt";
        StreamReader readerOne = new StreamReader(inputPathOne);
        StreamReader readerTwo = new StreamReader(inputPathTwo);
        int sameLines = 0;
        int differentLines = 0;
        using (readerOne)
        {
            using (readerTwo)
            {
                string currentLineTextOne = readerOne.ReadLine();
                string currentLineTextTwo = readerTwo.ReadLine();

                while (currentLineTextOne != null && currentLineTextTwo != null)
                {
                    int compareResult = string.Compare(currentLineTextOne, currentLineTextTwo);
                    if (compareResult == 0)
                    {
                        sameLines++;
                    }
                    if (compareResult != 0)
                    {
                        differentLines++;
                    }
                    currentLineTextOne = readerOne.ReadLine();
                    currentLineTextTwo = readerTwo.ReadLine();
                }
            }
        }
        Console.WriteLine("The same lines are: {0}", sameLines);
        Console.WriteLine("The different lines are: {0}", differentLines);
    }
}
