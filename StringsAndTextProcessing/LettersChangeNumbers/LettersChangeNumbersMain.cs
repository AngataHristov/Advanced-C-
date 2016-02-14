namespace LettersChangeNumbers
{
    using System;

    public class LettersChangeNumbersMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] strings = input
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = new double();

            foreach (string s in strings)
            {
                char firstLetter = s[0];
                char lastLetter = s[s.Length - 1];
                uint number = uint.Parse(s.Substring(1, s.Length - 2));

                double result = ProccessFirstLetter(firstLetter, number);

                result = ProcessLastLetter(lastLetter, result);

                totalSum += result;
            }

            Console.WriteLine("{0:F2}", totalSum);
        }

        private static double ProcessLastLetter(char lastLetter, double firsResult)
        {
            if (char.IsUpper(lastLetter))
            {
                return (double)firsResult - (lastLetter - 64);
            }

            return firsResult + (lastLetter - 96);
        }

        private static double ProccessFirstLetter(char firstLetter, uint number)
        {
            if (char.IsUpper(firstLetter))
            {
                return (double)number / (firstLetter - 64);
            }

            return number * (firstLetter - 96);
        }
    }
}
