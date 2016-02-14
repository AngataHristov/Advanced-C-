//Write a program that reads a string from the console and replaces all series
//of consecutive identical letters with a single one.

namespace SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLettersMain
    {
        public static void Main()
        {
            string pattern = @"(\w{1})\1+";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            string result = regex.Replace(text, "$1");

            Console.WriteLine(result);
        }
    }
}
