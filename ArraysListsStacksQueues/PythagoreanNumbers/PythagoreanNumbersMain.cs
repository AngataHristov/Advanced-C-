namespace PythagoreanNumbers
{
    using System;

    public class PythagoreanNumbersMain
    {
        public static void Main()
        {
            Console.Write("Enter the number of member: ");

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            FillArray(numbers);

            bool foundAny = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        int powResult = numbers[a] * numbers[a] + numbers[b] * numbers[b];

                        if ((powResult == numbers[c] * numbers[c]) && numbers[a] <= numbers[b])
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[a], numbers[b], numbers[c]);
                            foundAny = true;
                        }
                    }
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("No");
            }
        }

        private static void FillArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
