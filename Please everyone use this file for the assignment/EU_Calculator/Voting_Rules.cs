﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    class Voting_Rules
    {
        public static double Rules()
        {

            double Population = 0;
            double Members_State = 0;
            List<double> MemPop = new List<double>();

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
                                Members_State = 55 * 0.1;
                                Population = 65 * 0.1;
                            }
                            else if (Answer == 2)
                            {
                                Members_State = 72 * 0.1;
                                Population = 65 * 0.1;

                            }
                            else if (Answer == 3)
                            {
                                Members_State = 50 * 0.1;
                                Population = 0;
                            }
                            else
                            {
                                Members_State = 27 * 0.1;
                                Population = 0;
                            }
                            MemPop.Add(Members_State);
                            MemPop.Add(Population);



                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a number less than 4");
                        }
                        Console.WriteLine(MemPop);

                        return Population;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please only choose between 1 and 4");
                }

            }
        }
    }
}
