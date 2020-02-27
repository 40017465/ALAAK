using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    class Voting_Rules
    {
        public static double Rules(out double Members_State, out double Population)
        {

            while (true)
            {
                try
                {

                    Console.WriteLine("Which set of rules would you like to use?");
                    Console.WriteLine(" 1: Qualified Majority \n 2: Reinforced Qualified Majority \n 3: Simple Majority \n 4: Unaniminty");
                    int Answer = int.Parse(Console.ReadLine());
                    while (Answer <= 4)
                    {
                        try
                        {
                            if (Answer == 1)
                            {
                                Members_State = 55.0 ;
                                Population = 65.0;
                            }
                            else if (Answer == 2)
                            {
                                Members_State = 72.0;
                                Population = 65.0;

                            }
                            else if (Answer == 3)
                            {
                                Members_State = 50.0;
                                Population = 0.0;
                            }
                            else
                            {
                                Members_State = 27.0;
                                Population = 0.0;
                            }




                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number less than 4");
                        }

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please only choose between 1 and 4");
                }

            }
        }

    }
    public static int EuroZone()
        {
            Console.WriteLine("Would you like to incluce non Euro Zone? 1:Yes 2:No");
            int Answer = int.Parse(Console.ReadLine());
            if (Asnwer == 1)
            {
                Country.GetCountry();
            }

            else 
            {
                Country.RemoveCountry();            
            }              
        }
}
