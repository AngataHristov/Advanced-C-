namespace LineNumbers
{
    using System.IO;

    public class LineNumbersMain
    {
        public static void Main()
        {
            string pathForReading = "../../LineNumbersMain.cs";
            string pathForWriting = "../../LineNumbersMainFixed.txt";

            StreamReader reader = new StreamReader(pathForReading);
            StreamWriter writer = new StreamWriter(pathForWriting);

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int count = 1;

                    while (line != null)
                    {
                        string numberedLine = string.Format("{0,2}. {1}", count, line);

                        writer.WriteLine(numberedLine);

                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
