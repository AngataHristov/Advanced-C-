namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCountMain
    {
        public static void Main()
        {
            string wordsPath = "../../words.txt";
            string textPath = "../../text.txt";
            string resultPath = "../../result.txt";

            StreamReader wordsReader = new StreamReader(wordsPath);
            List<string> words = new List<string>();

            using (wordsReader)
            {
                string line = wordsReader.ReadLine();

                while (line != null)
                {
                    words.Add(line);

                    line = wordsReader.ReadLine();
                }
            }

            StreamReader textReader = new StreamReader(textPath);
            StreamWriter writer = new StreamWriter(resultPath);

            using (writer)
            {
                using (textReader)
                {
                    string[] text = textReader.ReadToEnd()
                        .Split(new[] { ' ', ',', '-', '.' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    foreach (string word in words)
                    {
                        int counter = 0;

                        foreach (string wrd in text)
                        {
                            if (wrd.ToLower() == word.ToLower())
                            {
                                counter++;
                            }
                        }

                        writer.WriteLine("{0}-{1}", word, counter);
                    }
                }
            }

        }
    }
}
