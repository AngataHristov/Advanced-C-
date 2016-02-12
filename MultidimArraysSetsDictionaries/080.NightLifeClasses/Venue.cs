namespace _080.NightLifeClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Venue
    {
        public Venue(string name)
        {
            this.Name = name;
            this.Preformances = new HashSet<string>();
        }

        public string Name { get; private set; }

        public ISet<string> Preformances { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("->{0}: {1}", this.Name, string.Join(", ", this.Preformances)));

            return result.ToString().Trim();
        }
    }
}
