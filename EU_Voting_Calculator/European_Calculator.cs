using System;

namespace EU_Voting_Calculator
{
    class European_Calculator
    {
        static void Main(string[] args)
        {
            var Country = new Country();

            Country.AddCountry("Austria", 8822000, true);
            Country.AddCountry("Belgium", 11539000, true);
            Country.AddCountry("Bulgaria", 7050000, false);
            Country.AddCountry("Croatia", 4130000, false);
            Country.AddCountry("Cyprus", 1198000, true);
            Country.AddCountry("Czech Republic", 10689000, false);
            Country.AddCountry("Denmark", 5771000, false);
            Country.AddCountry("Estonia", 1325000, true);
            Country.AddCountry("Finland", 5532000, true);
            Country.AddCountry("France", 65129000, true);
            Country.AddCountry("Germany", 83517000, true);
            Country.AddCountry("Greece", 10473000, true);
            Country.AddCountry("Hungary", 9684000, true);
            Country.AddCountry("Ireland", 4882000, false);
            Country.AddCountry("Italy", 60550000, true);
            Country.AddCountry("Latvia", 1906000, true);
            Country.AddCountry("Lithuania", 2759000, true);
            Country.AddCountry("Luxembourg", 615000, true);
            Country.AddCountry("Malta", 440000, true);
            Country.AddCountry("Netherlands", 17097000, true);
            Country.AddCountry("Poland", 37887000, false);
            Country.AddCountry("Portugal", 10226000, true);
            Country.AddCountry("Romania", 19364000, false);
            Country.AddCountry("Slovakia", 5457000, true);
            Country.AddCountry("Slovenia", 2078000, true);
            Country.AddCountry("Spain", 46736000, true);
            Country.AddCountry("Sweden", 10036000, false);

            /*
            if (false)
            {

                Country.RemoveCountry();                      
            }
            */


            //input placeholder
            int participatingRule = 1;
            int vote_rule = 1;


            Console.WriteLine(Country.GetCountry(participatingRule, vote_rule));
        }
    }
}
