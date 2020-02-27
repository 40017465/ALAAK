using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    class Results
    {
        public int Yes { get; set; }
        public int No { get; set; }
        public int Abstain { get; set; }
        public int final_result { get; set; }
        public double final_result_percent { get; set; }
        public double TotalPercentage { get; set; }
        public double NoPercentage { get; set; }
        public double AbstainPercentage { get; set; }

        //asks the users input holds on that info for later in the results function aswell as the percentages
        public void Votes(double percentage)
        {
            Console.WriteLine("Vote" + "\n" + "1. Yes" + "\n" + "2. No" + "\n" + "3. Abstain");

            bool flag = false;
            do
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    int test = Int32.Parse(input);

                    if (test >= 1 && test <= 3)
                    {
                        if (test == 1)
                        {
                            TotalPercentage += percentage;
                            Yes++;
                            flag = true;
                        }
                        else if (test == 2)
                        {
                            NoPercentage += percentage;

                            No++;
                            flag = true;
                        }
                        else
                        {
                            AbstainPercentage += percentage;
                            Abstain++;
                            flag = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter 1 2 or 3");
                    }
                }
                else
                {
                    Console.WriteLine("Enter 1 2 or 3");
                }
            }
            while (!flag);
        }

        //uses the rules which it got passed with voting info shows the final result
        public void results(int participatingRule, int vote_rule)
        {
            /* place holder
             * All Countries
             * Qualified Majority             = min of 15 vote yes or 65%
             * Reinforced Qualified Majority  = min of 20 vote yes or 65%
             * Simple Majority                = min of 14 vote yes or 0%
             * Unanimity                      = min of 27 vote yes or 0%
             * 
             * Eurozone only 
             * Qualified Majority             = min of 11 vote yes or 65%
             * Reinforced Qualified Majority  = min of 14 vote yes or 65%
             * Simple Majority                = min of 10 vote yes or 0%
             * Unanimity                      = min of 19 vote yes or 0%
            */

            Console.WriteLine();
            Console.WriteLine("The Votes");
            Console.Write("{0,2}" + " Voted for" + " Yes \t", Yes);
            Console.WriteLine("{0:f2}%" + " voted Yes", TotalPercentage);

            Console.Write("{0,2}" + " Voted for" + " No \t", No);
            Console.WriteLine("{0:f2}%" + " voted no", NoPercentage);

            Console.Write("{0,2}" + " Voted for" + " Abstain \t", Abstain);
            Console.WriteLine("{0:f2}%" + " voted Abstain ", AbstainPercentage);

            Console.WriteLine();

            if (participatingRule == 1)
            {
                double Qualified_Majority_percent = 65.0;
                double Reinforced_Qualified_Majority_percent = 65.0;
                double Simple_Majority_percent = 0.0;
                double Unanimity_percent = 0.0;

                if (vote_rule == 1)
                {
                    final_result_percent = Qualified_Majority_percent;
                }
                else if (vote_rule == 2)
                {
                    final_result_percent = Reinforced_Qualified_Majority_percent;
                }
                else if (vote_rule == 3)
                {
                    final_result_percent = Simple_Majority_percent;
                }
                else
                {
                    final_result_percent = Unanimity_percent;
                }
            }
            else
            {
                double Qualified_Majority_percent = 65.0;
                double Reinforced_Qualified_Majority_percent = 65.0;
                double Simple_Majority_percent = 0.0;
                double Unanimity_percent = 0.0;

                if (vote_rule == 1)
                {
                    final_result_percent = Qualified_Majority_percent;
                }
                else if (vote_rule == 2)
                {
                    final_result_percent = Reinforced_Qualified_Majority_percent;
                }
                else if (vote_rule == 3)
                {
                    final_result_percent = Simple_Majority_percent;
                }
                else
                {
                    final_result_percent = Unanimity_percent;
                }
            }

            if (participatingRule == 1)
            {
                int Qualified_Majority = 15;
                int Reinforced_Qualified_Majority = 20;
                int Simple_Majority = 14;
                int Unanimity = 27;

                if (vote_rule == 1)
                {
                    final_result = Qualified_Majority;
                }
                else if (vote_rule == 2)
                {
                    final_result = Reinforced_Qualified_Majority;
                }
                else if (vote_rule == 3)
                {
                    final_result = Simple_Majority;
                }
                else
                {
                    final_result = Unanimity;
                }
            }
            else
            {
                int Qualified_Majority = 11;
                int Reinforced_Qualified_Majority = 14;
                int Simple_Majority = 10;
                int Unanimity = 19;
                if (vote_rule == 1)
                {
                    final_result = Qualified_Majority;
                }
                else if (vote_rule == 2)
                {
                    final_result = Reinforced_Qualified_Majority;
                }
                else if (vote_rule == 3)
                {
                    final_result = Simple_Majority;
                }
                else
                {
                    final_result = Unanimity;
                }
            }

            if (Yes >= final_result & TotalPercentage >= final_result_percent)
            {
                Console.WriteLine("Approved!");
            }
            else
            {
                Console.WriteLine("Rejected!");
            }
        }
    }
}
