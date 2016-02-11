//Write a method that checks if the element at given position in a given array
//of integers is larger than its two neighbours (when such exist).

namespace LargerThanNeighbours
{
    using System;
    using System.Linq;

    public class LargerThanNeighboursMain
    {
        public static void Main()
        {
            Console.Write("Enter a sequence of integer numbers: ");

            int[] numbers = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

            for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
            {
                bool result = IsLargerThanNeighBours(numbers, currentIndex);

                Console.WriteLine(result);
            }
        }

        private static bool IsLargerThanNeighBours(int[] numbers, int currentPossition)
        {
            if (currentPossition == 0)
            {
                bool result = numbers[currentPossition] > numbers[currentPossition + 1];

                return result;
            }

            if (currentPossition == numbers.Length - 1)
            {
                bool result = numbers[currentPossition] > numbers[currentPossition - 1];

                return result;
            }

            bool finalResult = numbers[currentPossition] > numbers[currentPossition - 1] &&
                               numbers[currentPossition] > numbers[currentPossition + 1];

            return finalResult;
        }
    }
}
