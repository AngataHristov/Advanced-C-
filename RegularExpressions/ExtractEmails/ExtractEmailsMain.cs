//Write a program to extract all email addresses from a given text.
//The text comes at the only input line. Print the emails on the console,
//each at a separate line. Emails are considered to be in format <user>@<host>, 

namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ExtractEmailsMain
    {
        public static void Main()
        {
            string pattern = @"\b(\w*[-._]*\w+)([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\b";

            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            Match match = regex.Match(text);
            List<string> emails = new List<string>();

            while (match != Match.Empty)
            {
                string email = match.Value;

                if (email[0] != '.' && email[0] != '-' && email[0] != '_')
                {
                    emails.Add(email);
                }

                match = match.NextMatch();
            }

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
