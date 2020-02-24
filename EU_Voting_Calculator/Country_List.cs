using System;

namespace EU_Voting_Calculator
{
    public class Country_List
    {
        public string Name { get; }
        public int Population { get; }
        public bool EUZoneOnly { get; }

        public Country_List(string name, int population, bool euZoneOnly)
        {
            this.Name = name;
            this.Population = population;
            this.EUZoneOnly = euZoneOnly;
        }
    }
}