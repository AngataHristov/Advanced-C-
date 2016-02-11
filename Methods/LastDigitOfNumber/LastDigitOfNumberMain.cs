//Write a method that returns the last digit of a given integer as an English word.
//Test the method with different input values. Ensure you name the method properly.

namespace LastDigitOfNumber
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class LastDigitOfNumberMain
    {
        private static readonly IDictionary<int, string> digitWordPairs = new Dictionary<int, string>
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
        };

        public static void Main()
        {
            Console.Write("Enter integer number: ");

            int number = int.Parse(Console.ReadLine());

            int lastDigit = GetLastDigit(number);

            string digitAsWord = ConvertDigitToWord(lastDigit);

            Console.WriteLine(digitAsWord);
        }

        private static int GetLastDigit(int number)
        {
            //Just for practice
            Debug.Assert(number.GetType() == typeof(int), "invalid argument");

            int lastDigit = number % 10;

            return lastDigit;
        }

        private static string ConvertDigitToWord(int digit)
        {
            Debug.Assert(digit.GetType() == typeof(int), "invalid argument");

            return digitWordPairs[digit];
        }
    }
}
