using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
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

    public class Country
    {
        private List<Country_List> Countries = new List<Country_List>();

        public int TotalPopulation
        {
            get
            {
                int totalpopulation = 0;
                foreach (var item in Countries)
                {
                    totalpopulation += item.Population;
                }
                return totalpopulation;
            }
        }

        public double Percentage(int Population)
        {
            double percentage = 0;
            percentage = (100.0 / TotalPopulation) * Population;

            return percentage;
        }

        //prints each country and calls the voting function in the results class after all countries have been passed, calls results function
        //passes on both rules to the results class
        public string GetCountry(int participatingRule, int vote_rule)
        {
            Results vote = new Results();

            var GetCountries = new System.Text.StringBuilder();

            decimal total = 0;
            foreach (var country in Countries)
            {
                total += country.Population;
                Console.WriteLine(country.Name);
                vote.Votes(Percentage(country.Population));
            }
            vote.results(participatingRule, vote_ruyle);
            return GetCountries.ToString();
        }

        //adds each country to the list
        public void AddCountry(string name, int amount, bool euZoneOnly)
        {
            var addCountry = new Country_List(name, amount, euZoneOnly);
            Countries.Add(addCountry);
        }

        //removes countries not in EUZone
        public void RemoveCountry()
        {
            Countries.RemoveAll(remove => remove.EUZoneOnly == false);
        }
    }
}
