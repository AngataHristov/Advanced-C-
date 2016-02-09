//Write a program that reads from the console a number N and an array of integers given on a single line.
//Your task is to find all subsets within the array which have a sum equal to N and print them on the console
//(the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first.
//In case there aren't any subsets with the desired sum, print "No matching subsets." 

namespace SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSumsMain
    {
        public static void Main()
        {
            Console.Write("Enter integer number: ");

            int sum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a sequence of integer numbers: ");

            List<int> sequence = Console.ReadLine()
                .Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool foundAny = false;

            List<List<int>> combinationsSet = GetAllCombinations<int>(sequence);

            foreach (List<int> comb in combinationsSet)
            {
                if (comb.Sum() == sum)
                {
                    Console.WriteLine("{0} = {1}", string.Join(" + ", comb), sum);

                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        // SWEET
        private static List<List<T>> GetAllCombinations<T>(List<T> initialList)
        {
            var combinationsSet = new List<List<T>>();

            // The final number of sets will be 2^N (or 2^N - 1 if skipping empty set)
            int setCount = Convert.ToInt32(Math.Pow(2, initialList.Count()));

            // Start at 1 if you do not want the empty set
            for (int mask = 0; mask < setCount; mask++)
            {
                var nestedList = new List<T>();

                for (int j = 0; j < initialList.Count(); j++)
                {
                    // Each position in the initial list maps to a bit here
                    int pos = 1 << j;

                    if ((mask & pos) == pos)
                    {
                        nestedList.Add(initialList[j]);
                    }
                }

                combinationsSet.Add(nestedList);
            }

            return combinationsSet;
        }
    }
}
