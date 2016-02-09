// Write a program to read an array of numbers from the console, sort them and print them back on the console.
// The numbers should be entered from the console on a single line, separated by a space. 

namespace SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbersMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sequence of numbers: ");

            int[] numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[j] < numbers[i])
            //        {
            //            int num = numbers[j];
            //            numbers[j] = numbers[i];
            //            numbers[i] = num;
            //        }
            //    }
            //}

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
