namespace _080.NightLifeClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NightLifeMain
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            IDictionary<string, City> citiesByName = new Dictionary<string, City>();

            FillData(input, citiesByName);

            PrintInfo(citiesByName);
        }

        private static void FillData(string input, IDictionary<string, City> citiesByName)
        {
            while (input != "END")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] inputArgs = input.Split(';');

                string cityName = inputArgs[0];
                string venueName = inputArgs[1];
                string performance = inputArgs[2];

                if (!citiesByName.ContainsKey(cityName))
                {
                    City city = new City(cityName);
                    Venue venue = new Venue(venueName);

                    citiesByName[cityName] = city;
                    city.Venues.Add(venue);
                    venue.Preformances.Add(performance);
                }

                if (citiesByName.ContainsKey(cityName))
                {
                    Venue venue = new Venue(venueName);

                    if (!citiesByName[cityName].Venues.Any(v => v.Name == venueName))
                    {
                        citiesByName[cityName].Venues.Add(venue);
                    }

                    venue.Preformances.Add(performance);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintInfo(IDictionary<string, City> citiesByName)
        {
            StringBuilder result = new StringBuilder();

            foreach (KeyValuePair<string, City> city in citiesByName)
            {
                result.AppendLine(city.Value.ToString());
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
