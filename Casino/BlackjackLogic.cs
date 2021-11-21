using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Casino
{
    public class BlackjackLogic
    {

   


        public void playerHandCheck(int handTotal, int dealerTotal)
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


    }
}
