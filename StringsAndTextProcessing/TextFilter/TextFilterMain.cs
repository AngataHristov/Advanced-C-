//Write a program that takes a text and a string of banned words. 
//All words included in the ban list should be replaced with asterisks "*",
//equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".

namespace TextFilter
{
    using System;
    using System.Linq;
    using System.Text;

    public class TextFilterMain
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            StringBuilder text = new StringBuilder(input);

            foreach (string bannedWord in bannedWords)
            {
                string censore = new string('*', bannedWord.Length);
                text.Replace(bannedWord, censore);
            }

            Console.WriteLine();
            Console.WriteLine(text.ToString());
        }
    }
}
