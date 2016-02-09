// Write a program to sort an array of numbers and then print them back on the console.
// The numbers should be entered from the console on a single line, separated by a space. 

namespace SelectionSort
{
    using System;
    using System.Linq;

    public class SelectionSortMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sequence of numbers: ");

            int[] numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            SelectionSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minNum = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minNum])
                    {
                        minNum = j;
                    }

                    if (minNum != i)
                    {
                        int num = numbers[minNum];
                        numbers[minNum] = numbers[i];
                        numbers[i] = num;
                        minNum = i;
                    }
                }
            }
        }
    }
}


