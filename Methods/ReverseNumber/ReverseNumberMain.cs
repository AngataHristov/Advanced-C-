// Write a method that reverses the digits of a given floating-point number.

namespace ReverseNumber
{
    using System;
    using System.Text;

    public class ReverseNumberMain
    {
        public static void Main()
        {
            Console.Write("Enter number: ");

            string input = Console.ReadLine();

            double result = ReverseNumber(input);

            Console.WriteLine(result);
        }

        private static double ReverseNumber(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            string result = stringBuilder.ToString();

            double resultAsNumber = double.Parse(result);

            return resultAsNumber;
        }
    }
}
