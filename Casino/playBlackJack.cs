using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
   public class blackjackGame
    {



        public void playBlackJack()
        {
            
            Console.Clear();
            Random random = new Random();
            int num01 = random.Next(1, 11);
            int num02 = random.Next(1, 11);
            int handTotal = num01 + num02;

            while (handTotal < 21 || handTotal == 21)
            {
                Console.Clear();
                Console.WriteLine("your hand is: " + handTotal);
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Stand");
               int playerInput = Convert.ToInt32(Console.ReadLine());

                if (playerInput == 1)
                {
                    handTotal = handTotal + random.Next(1, 11);
                    playerInput = 2;




                }
                else if (playerInput == 2)
                {
                    Console.WriteLine("your total is: " + handTotal);
                    int d01 = random.Next(1, 11);
                    int d02 = random.Next(1, 11);
                    int dealerTotal = d01 + d02;



                    Console.WriteLine("the dealers total is: " + dealerTotal);

                    if (handTotal > dealerTotal)
                    {
                        Console.WriteLine("you won");
                        Console.ReadKey();
                        playBlackJack();

                    }
                    else if (handTotal == dealerTotal)
                    {
                        Console.WriteLine("Push, same totals");
                        Console.ReadKey();
                        playBlackJack();
                    }
                    else if (handTotal < dealerTotal)
                    {
                        Console.WriteLine("dealer won");
                        Console.ReadKey();
                        playBlackJack();

                    }


                    

                }

            } 


            

            

        }












    }
}
