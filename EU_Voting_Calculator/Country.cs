using System;
using System.Collections.Generic;

namespace calculator
{
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
            double percentage = 0.0;
            percentage = (100.0 / TotalPopulation) * Population;

            return percentage;
        }

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
            vote.results(participatingRule, vote_rule);
            return GetCountries.ToString();
        }

        public void AddCountry(string name, int amount, bool euZoneOnly)
        {
            var addCountry = new Country_List(name, amount, euZoneOnly);
            Countries.Add(addCountry);
        }

        public void RemoveCountry()
        {
            Countries.RemoveAll(remove => remove.EUZoneOnly == false);
        }
    }
}