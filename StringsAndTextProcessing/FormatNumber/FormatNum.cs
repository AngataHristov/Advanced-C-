// Problem 11. Format number
// 
// Write a program that reads a number and prints it as a decimal number, hexadecimal number,
// percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

class FormatNum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        Console.WriteLine("{0,15:F2}", int.Parse(input));

        Console.WriteLine(String.Format("0x{0:X}".PadLeft(18), int.Parse(input)));

        Console.WriteLine("{0,15:P}", int.Parse(input));

        Console.WriteLine("{0,15:E}", int.Parse(input));
    }
}
