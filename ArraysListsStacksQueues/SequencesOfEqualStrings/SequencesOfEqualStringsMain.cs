// Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive).
// The input strings are given as a single line, separated by a space. 

namespace SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class SequencesOfEqualStringsMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter a sequence of strings, separate by single space: ");

            string[] elements = Console.ReadLine().Split();

            var groups = elements.GroupBy(name => name);

            PrintElements(groups);

            // GroupElements(elements);
        }

        private static void PrintElements(IEnumerable<IGrouping<string, string>> groups)
        {
            foreach (var group in groups)
            {
                Console.WriteLine(string.Join(" ", group));
            }
        }

        // My way...

        //private static void GroupElements(string[] elements)
        //{
        //    HashSet<string> keys = new HashSet<string>();

        //    foreach (string element in elements)
        //    {
        //        keys.Add(element);
        //    }

        //    foreach (var uniqueElement in keys)
        //    {
        //        foreach (var element in elements)
        //        {
        //            if (uniqueElement == element)
        //            {
        //                Console.Write("{0} ", uniqueElement);
        //            }
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }
}
