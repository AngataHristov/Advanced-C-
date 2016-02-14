//Write a program that reads a keyword and some text from the console and prints all sentences from the text,
//containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. 

namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractorMain
    {
        public static void Main()
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine();

            string template = string.Format(@"\b([\w+|\s]*{0}\s[\w+|\s]*[!?.])", keyWord);

            Regex regex = new Regex(template);

            Match match = regex.Match(text);

            while (match != Match.Empty)
            {
                Console.WriteLine(match.Value);

                match = match.NextMatch();
            }
        }
    }
}
