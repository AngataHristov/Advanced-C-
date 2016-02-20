namespace OddLines
{
    using System;
    using System.IO;

    public class OddLinesMain
    {
        public static void Main()
        {
            string path = "../../text.txt";
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                string line = reader.ReadLine();

                int count = 0;
                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
