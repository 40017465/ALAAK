using System;
using System.Collections.Generic;
using System.Text;

namespace EU_Calculator
{
    class Results
    {
        //Each of the following stores the data from where its used and is updated when its used i.e from Votes. Plus results later on will use it. 
        public int Yes { get; set; }
        public int No { get; set; }
        public int Abstain { get; set; }
        public int final_result { get; set; }
        public double final_result_percent { get; set; }
        public double TotalPercentage { get; set; }
        public double NoPercentage { get; set; }
        public double AbstainPercentage { get; set; }

        //After the country is shown the user is then asked for an input and that input is stored aswell as the percentage which will be used later in results.  
        public void Votes(double percentage)
        {
            Console.WriteLine("Vote" + "\n" + "1. Yes" + "\n" + "2. No" + "\n" + "3. Abstain");

            bool flag = false;
            do
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    int input_number = Int32.Parse(input);

                    if (input_number >= 1 && input_number <= 3)
                    {
                        if (input_number == 1)
                        {
                            TotalPercentage += percentage;     //adds the current percentage to over all TotalPercentage. 
                            Yes++;                             //adds a +1 to the Yes counter.
                            flag = true;                       //breaks out of the loop.
                        }
                        else if (input_number == 2)
                        {
                            NoPercentage += percentage;         //adds the current percentage of NoPercentage to over all percentage of NoPercentage. 
                            No++;                               //adds a +1 to the No counter.
                            flag = true;
                        }
                        else
                        {
                            AbstainPercentage += percentage;    //adds the current percentage of AbstainPercentage to over all percentage of AbstainPercentage.
                            Abstain++;                          //adds a +1 to the Abstain counter.
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

        //Using the rules which it got passed to plus the above data, it will test to see if its Approved or Rejected.
        public void results(double Members_State, double Population)
        {
            
            Console.WriteLine();
            Console.WriteLine("The Votes");                                         //This parts prints how many votes for each yes ,no or abstain
            Console.Write("{0,2}" + " Voted for" + " Yes \t", Yes);                 //and prints the percentage of each aswell.
            Console.WriteLine("{0:f2}%" + " voted Yes", TotalPercentage);

            Console.Write("{0,2}" + " Voted for" + " No \t", No);
            Console.WriteLine("{0:f2}%" + " voted no", NoPercentage);

            Console.Write("{0,2}" + " Voted for" + " Abstain \t", Abstain);
            Console.WriteLine("{0:f2}%" + " voted Abstain ", AbstainPercentage);

            Console.WriteLine();

            var final_result = (100.0 / (Yes + No + Abstain) * Yes);
            
            if (final_result >= Members_State & TotalPercentage >= Population)      //This tests if both total vote and the total population percentage 
            {                                                                       //meets the requirements of the rules which was set earlier.  
                Console.WriteLine("Approved!");
            }
            else
            {
                Console.WriteLine("Rejected!");
            }
        }
    }
}
