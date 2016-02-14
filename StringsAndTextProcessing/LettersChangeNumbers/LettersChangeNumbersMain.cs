namespace LettersChangeNumbers
{
    using System;

    public class LettersChangeNumbersMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] strings = input
                .Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = new double();

            foreach (string s in strings)
            {
                char firstLetter = s[0];
                char lastLetter = s[s.Length - 1];
                uint number = uint.Parse(s.Substring(1, s.Length - 2));

                double firsResult = new double();

                if (char.IsUpper(firstLetter))
                {
                    firsResult = (double)number / (firstLetter - 64);
                }
                else
                {
                    firsResult = number * (firstLetter - 96);
                }

                double result = new double();

                if (char.IsUpper(lastLetter))
                {
                    result = (double)firsResult - (lastLetter - 64);
                }
                else
                {
                    result = firsResult + (lastLetter - 96);
                }

                totalSum += result;
            }

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
