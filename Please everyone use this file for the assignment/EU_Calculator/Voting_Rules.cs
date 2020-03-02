using System;

namespace EU_Calculator
{
    //This Class is used for deciding which rules you would like to follow and whether you would like to include the Euro Zone.
    class Voting_Rules
    {

        //This is the function which lets you set the rules.
        public static void Rules(out double Members_State, out double Population)
        {

            int Answer = -1;
            do
            {
                Console.WriteLine("Which set of rules would you like to use?");
                Console.WriteLine(" 1: Qualified Majority \n 2: Reinforced Qualified Majority \n 3: Simple Majority \n 4: Unaniminty");
                if (!int.TryParse(Console.ReadLine(), out Answer))
                {
                    Console.WriteLine("Please only enter 1 to 4");
                }
            }
            while (Answer < 1 || Answer > 4);

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
                Population = 50.0;
            }

            else
            {
                Members_State = 100.0;
                Population = 100.0;
            }
 
        }

        //This is the function to let you decide whether or not to include the Euro Zone.
        public static int EuroZone()
        {
            int Answer = -1;
            do
            {
                Console.WriteLine("Would you like to include non Euro Zone countries?\n 1: Yes\n 2: No");
                if (!int.TryParse(Console.ReadLine(), out Answer))
                {
                    Console.WriteLine("Please only enter 1 or 2");
                    
                }
                
            } 
            while (Answer < 0 || Answer > 2);
            
            return Answer;
           
        }
    }
}