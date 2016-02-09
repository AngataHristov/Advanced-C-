//Write a program to find all increasing sequences inside an array of integers.
//The integers are given on a single line, separated by a space.
//Print the sequences in the order of their appearance in the input array,
//each at a single line. Separate the sequence elements by a space.
//Find also the longest increasing sequence and print it at the last line.
//If several sequences have the same longest length, print the left-most of them. 

namespace LongestIncreasingSequence
{
    using System;
    using System.Linq;

    public class LongestIncreasingSequenceMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter a sequence of numbers: ");

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxLength = 1;
            int endElement = 0;

            Console.Write("{0} ", input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > input[i - 1])
                {
                    Console.Write("{0} ", input[i]);

                    counter++;
                }
                else
                {
                    counter = 1;

                    Console.WriteLine();
                    Console.Write("{0} ", input[i]);
                }

                if (counter > maxLength)
                {
                    maxLength = counter;
                    endElement = i;
                }
            }

            Console.WriteLine();
            Console.Write("Longest: ");

            for (int j = endElement - maxLength + 1; j <= endElement; j++)
            {
                Console.Write("{0} ", input[j]);
            }

            Console.WriteLine();
        }
    }
}
