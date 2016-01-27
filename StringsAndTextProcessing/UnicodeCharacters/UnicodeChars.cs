// Problem 10. Unicode characters
// 
// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;

class UnicodeChars
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("ASCII table code  of symbols are: ");
        foreach (var symbol in text)
        {
            Console.Write("\\u{0:X4} ",(int)symbol);
        }
        Console.WriteLine();
    }
}
