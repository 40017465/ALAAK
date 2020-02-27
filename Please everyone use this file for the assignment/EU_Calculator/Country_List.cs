using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    public class Country_List
    {   
        //pulling country information and changing names
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
        
        //This works by looping the countries list and selecting that country's population 
        //which then is added to the totalpopulation once the loop end totalpopulation is returned.
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
        //This works by being given the country's population and running the calculation 
        //which it uses Totalpopulation above to help, once done the percentage is returned.
        public double Percentage(int Population)
        {
            double percentage = 0;
            percentage = (100.0 / TotalPopulation) * Population;

            return percentage;
        }

        //Prints each country and calls the voting function in the results class after all countries have been passed, calls results function
        //passes on both rules to the results class
        public string GetCountry(double Members_State, double Population)
        {
            Results vote = new Results();

            var GetCountries = new System.Text.StringBuilder();

            decimal total = 0;
            foreach (var country in Countries)
            {
                total += country.Population;
                Console.WriteLine(country.Name);
                vote.Votes(Percentage(country.Population));         //calls votes function aswell as passing the percentage of the current country.
            }
            vote.results(Members_State, Population);                //Runs results function after loop is done.
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
