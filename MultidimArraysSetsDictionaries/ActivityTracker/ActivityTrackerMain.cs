namespace ActivityTracker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;

    public class ActivityTrackerMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            SortedDictionary<int, SortedDictionary<string, int>> distanceByUserAndDateTime = new SortedDictionary<int, SortedDictionary<string, int>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            FillData(distanceByUserAndDateTime, numberOfInputs);

            Print(distanceByUserAndDateTime);
        }

        private static void FillData(
            SortedDictionary<int, SortedDictionary<string, int>> distanceByUserAndDateTime,
            int numberOfInputs)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');

                string dateTimeAsString = currentLine[0];
                int month = int.Parse(dateTimeAsString.Substring(dateTimeAsString.IndexOf('/') + 1, 2));

                string name = currentLine[1];
                int distance = int.Parse(currentLine[2]);

                if (!distanceByUserAndDateTime.ContainsKey(month))
                {
                    distanceByUserAndDateTime[month] = new SortedDictionary<string, int>();
                    distanceByUserAndDateTime[month].Add(name, distance);
                }

                else if (distanceByUserAndDateTime.ContainsKey(month) && !distanceByUserAndDateTime[month].ContainsKey(name))
                {
                    distanceByUserAndDateTime[month].Add(name, distance);
                }

                else if (distanceByUserAndDateTime.ContainsKey(month) && distanceByUserAndDateTime[month].ContainsKey(name))
                {
                    distanceByUserAndDateTime[month][name] += distance;
                }
            }
        }

        private static void Print(SortedDictionary<int, SortedDictionary<string, int>> distanceByUserAndDateTime)
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<int, SortedDictionary<string, int>> nameByDate in distanceByUserAndDateTime)
            {
                result.Append(string.Format("{0}: ", nameByDate.Key));

                int keyCount = nameByDate.Value.Count;
                string test = String.Empty;;
                foreach (KeyValuePair<string, int> distanceByName in nameByDate.Value)
                {
                    result.Append(string.Format("{0}({1})", distanceByName.Key, distanceByName.Value));

                    if (keyCount > 1)
                    {
                        result.Append(", ");
                    }

                    keyCount--;
                }

                result.AppendLine();
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
