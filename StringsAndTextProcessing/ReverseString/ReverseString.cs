// Problem 2. Reverse string
// 
// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static string ReverseText(string text)
    {
        StringBuilder reverse = new StringBuilder(text.Length);
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse.Append(text[i]);
        }
        return reverse.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter text for reversing: ");
        string text = Console.ReadLine();
        string reversedText = ReverseText(text);
        Console.WriteLine("The reversed text is: \n" + reversedText);
        Console.WriteLine();
    }
}
