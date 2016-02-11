// Write a method that returns the index of the first element in array that is larger than its neighbours,
// or -1 if there's no such element. Use the method from the previous exercise in order to re.

namespace FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    public class FirstLargerThanNeighboursMain
    {
        public static void Main()
        {
            Console.Write("Enter a sequence of integer numbers: ");

            int[] numbers = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

            int result = GetIndexOfTheFirstElementLargerThanNeighbours(numbers);

            Console.WriteLine(result);
        }

        private static int GetIndexOfTheFirstElementLargerThanNeighbours(int[] numbers)
        {
            int index = -1;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    index = i;

                    return index;
                }
            }

            return index;
        }
    }
}
