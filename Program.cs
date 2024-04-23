using System;

namespace loops_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNum, oddSum, counter = 0, counterAdd = 0;
            bool ligma = true;
            string userContinue;
            while (ligma = true) {

                Console.WriteLine("This is an odd sum calculator, it will add the total of each odd number from 1 to your number together.");
                userNum = int.Parse(Console.ReadLine());
                for (int i = userNum; i > 1; i--)
                {
                    counterAdd++;
                    if (i % 2 == 0)
                    {
                        //even
                        //does nothing
                    }
                    else
                    {
                        counter = counter + counterAdd;
                        //odd
                    }
                }

                Console.WriteLine($"the oddsum up to your number is {counter}");
                Console.WriteLine("would you like to go again? (yes or no)");
                userContinue = Console.ReadLine();
                if (userContinue.ToLower() == "no")
                {
                    ligma = false;
                }
                if (userContinue.ToLower() == "yes")
                {
                    counter = 0; 
                    counterAdd = 0;
                }
                else
                {
                    Console.WriteLine("you made a spelling error so i am going to make you go through it again");
                    Console.WriteLine("be better at typing next time");
                    counter = 0;
                    counterAdd = 0;
                }
            }
        }
    }
}