using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    //This Class is used for deciding which rules you would like to follow and whether you would like to include the Euro Zone.
    class Voting_Rules
    {
        //This is the function which lets you set the rules.
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
                                Members_State = 55.0;
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




        //This is the function to let you decide whether or not to include the Euro Zone.
        public static int EuroZone()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Would you like to incluce non Euro Zone? 1:Yes 2:No");
                    int Answer = int.Parse(Console.ReadLine());
                    while (Answer <= 2)
                    {
                        try
                        {

                            if (Answer == 1)
                            {
                                Country.GetCountry();
                            }

                            else
                            {
                                Country.RemoveCountry();
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please don't enter more than 2");
                        }

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please only enter 1 or 2");
                }


            }



        }
    }
}


