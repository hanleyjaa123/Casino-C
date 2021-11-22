using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Casino
{
    public class BlackjackLogic
    {


        Random random = new Random();
        blackjackGame sendBack = new blackjackGame();

        public void playerHandCheck(int handTotal, int dealerTotal) // right here it takes the inputs in and apply s it to the logic below
        {
// unused at the moment         Random random = new Random();
            


            if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer Busted, you won!");
                Console.ReadKey();
                sendBack.playBlackJack();

            } 
            else if (handTotal > dealerTotal) // logic checks, seeing which hand between the two won. 
            {
                Console.WriteLine("you won");
                Console.ReadKey();
                sendBack.playBlackJack();

            }
            else if (handTotal == dealerTotal)
            {
                Console.WriteLine("Push, same totals");
                Console.ReadKey();
                sendBack.playBlackJack();
            }
            else if (handTotal < dealerTotal)
            {
                Console.WriteLine("dealer won");
                Console.ReadKey();
                sendBack.playBlackJack();

            }

        }   



        public void menuCheck(int playerInput, int handTotal, int firstCard) // playerInput is for players choice within the menu(hit,stand,menu) handTotal is players total, firstCard is the dealers first randomly gen card number( in blackjack the player can see first card of dealers)
        {
            
            Program mainScreen = new Program();
            
            if (playerInput == 1) // if statements, checking players input. if anything except a int is inputed, the application will brake. 
            {

                sendBack.hitCommand(handTotal);
                

            }
            else if (playerInput == 2)
            {

                 sendBack.standCommand(handTotal, firstCard);

            }
            else if (playerInput == 3)
            {
                Console.Clear();
                mainScreen.loadMain();


            }


        }






    }
}
