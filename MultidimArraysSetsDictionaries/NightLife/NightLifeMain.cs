namespace NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class NightLifeMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            IDictionary<string, SortedDictionary<string, HashSet<string>>> performancesByVenuesAndCities =
                new Dictionary<string, SortedDictionary<string, HashSet<string>>>();

            FillData(input, performancesByVenuesAndCities);

            PrintInfo(performancesByVenuesAndCities);
        }

        private static void FillData(
                                     string input,
                                     IDictionary<string, SortedDictionary<string, HashSet<string>>> performancesByVenuesAndCities)
        {
            while (input != "END")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] inputArgs = input.Split(';');

                string city = inputArgs[0];
                string venue = inputArgs[1];
                string performance = inputArgs[2];

                if (!performancesByVenuesAndCities.ContainsKey(city))
                {
                    performancesByVenuesAndCities[city] = new SortedDictionary<string, HashSet<string>>();
                    performancesByVenuesAndCities[city][venue] = new HashSet<string>();
                    performancesByVenuesAndCities[city][venue].Add(performance);
                }

                if (performancesByVenuesAndCities.ContainsKey(city) &&
                    !performancesByVenuesAndCities[city].ContainsKey(venue))
                {
                    performancesByVenuesAndCities[city][venue] = new HashSet<string>();
                    performancesByVenuesAndCities[city][venue].Add(performance);
                }

                if (performancesByVenuesAndCities.ContainsKey(city) &&
                    performancesByVenuesAndCities[city].ContainsKey(venue))
                {
                    performancesByVenuesAndCities[city][venue].Add(performance);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintInfo(
            IDictionary<string, SortedDictionary<string, HashSet<string>>> performancesByVenuesAndCities)
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<string, SortedDictionary<string, HashSet<string>>> venuesByCity in performancesByVenuesAndCities)
            {
                result.AppendLine(venuesByCity.Key);

                foreach (KeyValuePair<string, HashSet<string>> performancesByVenue in venuesByCity.Value)
                {
                    result.AppendLine(string.Format("->{0}: {1}", performancesByVenue.Key, string.Join(", ", performancesByVenue.Value)));
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
