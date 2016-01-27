// Problem 6. String length
// 
// Write a program that reads from the console a string of maximum 20 characters.If the length of
// the string is less than 20, the rest of the characters should be filled with*.
// Print the result string into the console.

using System;
using System.Text.RegularExpressions;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            string rest = text.Substring(21);
            string fixedText = text.Remove(21);
            fixedText += new string('*', rest.Length);
            Console.WriteLine(fixedText);
        }
        else
        {
            Console.WriteLine(text);
        }
        Console.WriteLine();
    }
}
