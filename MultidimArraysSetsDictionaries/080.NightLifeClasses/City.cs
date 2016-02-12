namespace _080.NightLifeClasses
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class City
    {
        public City(string name)
        {
            this.Name = name;
            this.Venues = new List<Venue>();
        }

        public string Name { get; private set; }

        public IList<Venue> Venues { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.Name);

            var sortedVenueses = this.Venues.OrderBy(v => v.Name);

            foreach (Venue venue in sortedVenueses)
            {
                result.AppendLine(venue.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
