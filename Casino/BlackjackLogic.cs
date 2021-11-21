using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Casino
{
    public class BlackjackLogic
    {

   


        public void playerHandCheck(int handTotal, int dealerTotal) // right here it takes the inputs in and applys it to the logic below
        {
// unused at the moment         Random random = new Random();
            blackjackGame playBlack = new blackjackGame();


            if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer Busted, you won!");
                Console.ReadKey();
                playBlack.playBlackJack();

            } 
            else if (handTotal > dealerTotal) // logic checks, seeing which hand between the two won. 
            {
                Console.WriteLine("you won");
                Console.ReadKey();
                playBlack.playBlackJack();

            }
            else if (handTotal == dealerTotal)
            {
                Console.WriteLine("Push, same totals");
                Console.ReadKey();
                playBlack.playBlackJack();
            }
            else if (handTotal < dealerTotal)
            {
                Console.WriteLine("dealer won");
                Console.ReadKey();
                playBlack.playBlackJack();

            }

        }   



        public void menuCheck(int playerInput)
        {
            

            if (playerInput == 1) // if statements, checking players input. if anything except a int is inputed, the application will brake. 
            {
               
                }




            }
            else if (playerInput == 2) // [STAND COMMAND]
            {
                Console.Clear();
                Console.WriteLine("your total is: " + handTotal);
                // there is 100% a better way to do this, just gotta figure out how. When the player stands, it will then generate the dealers hand, and get dealers total.

                int d02 = random.Next(1, 11);

                int dealerTotal = d01 + d02;
                while (dealerTotal < 17)
                {
                    int d03 = random.Next(1, 11);
                    dealerTotal = dealerTotal + d03;

                }


                Console.WriteLine("the dealers total is: " + dealerTotal); // after generating the dealers hand, it will be displayed for the user.

                logic.playerHandCheck(handTotal, dealerTotal);






            }
            else if (playerInput == 3) // last input to return to main menu.
            {



            }


        }


    }
}
