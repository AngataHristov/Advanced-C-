namespace Phonebook
{
    using System;
    using System.Collections.Generic;

    public class PhonebookMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, string> phoneNumberByName = new Dictionary<string, string>();

            FillPhonebook(input, phoneNumberByName);

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                if (input.Split('-').Length > 1)
                {
                    FillPhonebook(input, phoneNumberByName);

                    continue;
                }

                if (phoneNumberByName.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}", input, phoneNumberByName[input]);

                    continue;
                }

                Console.WriteLine("Contact {0} does not exist.", input);
            }
        }

        private static void FillPhonebook(string input, IDictionary<string, string> phoneNumberByName)
        {
            while (input != "search")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] inputArgs = input.Split('-');

                string name = inputArgs[0];
                string phoneNumber = inputArgs[1];

                if (!phoneNumberByName.ContainsKey(name) || phoneNumberByName[name] != phoneNumber)
                {
                    phoneNumberByName[name] = phoneNumber;
                }

                input = Console.ReadLine();
            }
        }
    }
}
