using System;

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
        public double Yes_Percentage { get; set; }
        public double No_Percentage { get; set; }
        public double Abstain_Percentage { get; set; }

        //After the country is shown to the user is then asked for an input and that input and percentage is stored which will be used later in results.  
        public void Votes(double percentage)
        {
            Console.WriteLine("Vote" + "\n" + "1. Yes" + "\n" + "2. No" + "\n" + "3. Abstain");

            int userinput = -1;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out userinput))
                {
                    Console.WriteLine("Enter 1 2 or 3");
                }
                else
                {
                    if (userinput < 1 || userinput > 3)
                    {
                        Console.WriteLine("Enter 1 2 or 3");
                    }
                }
            }
            while (userinput < 1 || userinput > 3);


            if (userinput == 1)
            {
                Yes_Percentage += percentage;     //adds the current percentage to over all Yes_Percentage. 
                Yes++;                             //adds a +1 to the Yes counter.
            }
            else if (userinput == 2)
            {
                No_Percentage += percentage;         //adds the current percentage of NoPercentage to over all percentage of No_Percentage. 
                No++;                               //adds a +1 to the No counter.
            }
            else
            {
                Abstain_Percentage += percentage;    //adds the current percentage of AbstainPercentage to over all percentage of Abstain_Percentage.
                Abstain++;                          //adds a +1 to the Abstain counter.
            }
        }
        

        //Using the rules which it got passed to plus the data from earlier, it will test to see if its Approved or Rejected.
        public void results(double Members_State, double Population)
        {            
            Console.WriteLine();
            Console.WriteLine("The Votes");                                         //This parts prints how many votes for each yes ,no or abstain
            Console.Write("{0,2}" + " Voted for" + " Yes \t", Yes);                 //and prints the population percentage of each aswell.
            Console.WriteLine("{0:f2}%" + " in population voted Yes", Yes_Percentage);

            Console.Write("{0,2}" + " Voted for" + " No \t", No);
            Console.WriteLine("{0:f2}%" + " in population voted no", No_Percentage);

            Console.Write("{0,2}" + " Voted for" + " Abstain \t", Abstain);
            Console.WriteLine("{0:f2}%" + " in population voted Abstain ", Abstain_Percentage);

            Console.WriteLine();

            var final_result = (100.0 / (Yes + No + Abstain) * Yes);
            
            if (final_result >= Members_State && Yes_Percentage >= Population)      //This tests if both total Yes vote and the total Yes_Percentage(population) 
            {                                                                       //meets the requirements of the rules which was set earlier.  
                Console.WriteLine("Approved!");
            }
            else
            {
                Console.WriteLine("Rejected!");
                Console.WriteLine();

                if (final_result < Members_State)                                                       //Prints the requirements if rejected
                {                                                                                       //prints out the one which failed or both. 
                    Console.WriteLine("Needed a minimum of " + Members_State + "%" + " vots in yes");
                }
                if (Yes_Percentage < Population)
                {
                    Console.WriteLine("Needed a minimum of " + Population + "%" + " in population to vote yes");
                }
            }
        }
    }
}