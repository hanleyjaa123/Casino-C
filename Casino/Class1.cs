using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
   public class Class1
    {



        public void gameMechanic()
        {
            
            Console.Clear();
            Random random = new Random();
            int num01 = random.Next(1, 11);
            int num02 = random.Next(1, 11);
            int handTotal = num01 + num02;

            /* for (int i = 0; i < 2; i++)
             {
                 randomCard(random);
             }*/
            Console.WriteLine("your hand is, " + handTotal);
            Console.WriteLine(" ");
            Console.WriteLine("1. Stand ");
            Console.WriteLine("2. Hit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                if (handTotal > 21)
                {
                    Console.WriteLine("you busted!");
                }
                else if (handTotal == 21)
                {
                    Console.WriteLine("Blackjack!");
                }
                else if (handTotal < 21)
                {
                    Console.WriteLine("Good luck dealers hand is:");
                    int dealerHand = random.Next(1, 11);
                    Console.WriteLine(dealerHand + random.Next(1, 11));
                }
            }
            else if (input == "2")
            {
               int newTotal = handTotal + random.Next(1, 11);
                Console.WriteLine("your new total is " + newTotal);
            }

            

        }

        private void randomCard(Random random)
        {
            Console.WriteLine(random.Next(1, 11));


        }








    }
}
