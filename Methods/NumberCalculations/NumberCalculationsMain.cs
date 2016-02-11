// Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers.
// Overload the methods to work with numbers of type double and decimal.

namespace NumberCalculations
{
    using System;
    using System.Linq;

    public class NumberCalculationsMain
    {
        public static void Main()
        {
            Console.Write("Enter a sequence of type double numbers: ");

            double[] doubleNumbers = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n))
                    .ToArray();

            Console.Write("Enter a sequence of type decimal numbers: ");

            decimal[] decimalNumbers = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => decimal.Parse(n))
                    .ToArray();

            Console.WriteLine("Double type numbers result: ");
            Console.WriteLine(Min(doubleNumbers));
            Console.WriteLine(Max(doubleNumbers));
            Console.WriteLine(Sum(doubleNumbers));
            Console.WriteLine("{0:F2}", Average(doubleNumbers));
            Console.WriteLine(Product(doubleNumbers));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Decimal type numbers result: ");
            Console.WriteLine(Min(decimalNumbers));
            Console.WriteLine(Max(decimalNumbers));
            Console.WriteLine(Sum(decimalNumbers));
            Console.WriteLine("{0:F2}", Average(decimalNumbers));
            Console.WriteLine(Product(decimalNumbers));
            Console.WriteLine(new string('-', 20));
        }

        private static decimal Min(decimal[] numbers)
        {
            decimal minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        private static double Min(double[] numbers)
        {
            double minNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        private static decimal Max(decimal[] numbers)
        {
            decimal maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        private static double Max(double[] numbers)
        {
            double maxNumber = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        private static decimal Sum(decimal[] numbers)
        {
            decimal sum = new int();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static double Sum(double[] numbers)
        {
            double sum = new double();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static decimal Average(decimal[] numbers)
        {
            decimal sum = new int();
            decimal average = new decimal();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = sum / numbers.Length;

            return average;
        }

        private static double Average(double[] numbers)
        {
            double sum = new double();
            double average = new double();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = sum / numbers.Length;

            return average;
        }

        private static decimal Product(decimal[] numbers)
        {
            decimal product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }

        private static double Product(double[] numbers)
        {
            double product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
