//Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation).
//You may re-use your code from a previous homework and modify it. 

namespace GenericArraySort
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class GenericArraySortMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates =
            {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
        };

            Console.WriteLine(SortArray(numbers));
            Console.WriteLine(SortArray(strings));
            Console.WriteLine(SortArray(dates));
        }

        private static string SortArray<T>(IEnumerable<T> array)
            where T : IComparable<T>
        {
            List<T> tempList = array.ToList();
            List<T> sorted = new List<T>();

            while (tempList.Count != 0)
            {
                var x = tempList.Min();
                sorted.Add(x);
                tempList.Remove(x);
            }

            return PrintArray(sorted);
        }

        private static string PrintArray<T>(IEnumerable<T> array)
        {
            return string.Join(", ", array);
        }
    }
}
