//Write a program to find how many times a given string appears in a given text as substring.
//The text is given at the first input line. The search string is given at the second input line.
//The output is an integer number. Please ignore the character casing.
//Overlapping between occurrences is allowed. 

namespace CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrencesMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter text.");

            string text = Console.ReadLine();

            Console.Write("Enter word for searching: ");

            string word = Console.ReadLine();

            int counter = new int();
            int index = 0;

            while (true)
            {
                int found = text.ToLower()
                            .IndexOf(word, index);

                if (found < 0)
                {
                    break;
                }

                counter++;
                index = found + word.Length;
            }

            Console.WriteLine(counter);
        }
    }
}
