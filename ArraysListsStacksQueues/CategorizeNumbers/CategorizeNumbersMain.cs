// Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets,
// one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with
// non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 

namespace CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class CategorizeNumbersMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter a sequence of numbers: ");

            double[] numbers = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();

            List<double> roundNums = new List<double>();
            List<double> floatNums = new List<double>();

            ArrangeNumbers(numbers, roundNums, floatNums);

            string floatNumsResult = string.Format(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", floatNums),
                floatNums.Min(),
                floatNums.Max(),
                floatNums.Sum(),
                floatNums.Average());

            string roundNumsResult = string.Format(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", roundNums),
                roundNums.Min(),
                roundNums.Max(),
                roundNums.Sum(),
                roundNums.Average());

            Console.WriteLine(floatNumsResult);
            Console.WriteLine(roundNumsResult);
        }

        private static void ArrangeNumbers(double[] numbers, List<double> roundNums, List<double> floatNums)
        {
            foreach (double number in numbers)
            {
                if (number % 1 == 0)
                {
                    roundNums.Add(number);
                }
                else
                {
                    floatNums.Add(number);
                }
            }
        }
    }
}
