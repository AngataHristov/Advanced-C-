//Modify the program you wrote for the previous problem to print the results in the following way:
//each line should contain the operands (numbers that form the desired sum) in ascending order;
//the lines containing fewer operands should be printed before those with more operands;
//when two lines have the same number of operands, the one containing the smallest operand
//should be printed first. If two or more lines contain the same number of operands and have
//the same smallest operand, the order of printing is not important. 

namespace SortedSubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortedSubsetSumsMain
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

            List<SortedSet<int>> combinationsSet = GetAllCombos<int>(sequence);

            var sortedCombinationSet = combinationsSet.OrderBy(l => l.Count);

            foreach (SortedSet<int> comb in sortedCombinationSet)
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
        private static List<SortedSet<T>> GetAllCombos<T>(List<T> initialList)
        {
            var combinationsSet = new List<SortedSet<T>>();

            // The final number of sets will be 2^N (or 2^N - 1 if skipping empty set)
            int setCount = Convert.ToInt32(Math.Pow(2, initialList.Count()));

            // Start at 1 if you do not want the empty set
            for (int mask = 0; mask < setCount; mask++)
            {
                var nestedList = new SortedSet<T>();

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
