﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Casino
{
    public class BlackjackLogic
    {

   


        public void playerHandCheck(int handTotal, int dealerTotal) // right here it takes the inputs in and apply s it to the logic below
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



        public void menuCheck(int playerInput, int handTotal)
        {
            blackjackGame sendBack = new blackjackGame();
            Program mainScreen = new Program();

            if (playerInput == 1) // if statements, checking players input. if anything except a int is inputed, the application will brake. 
            {

                sendBack.hitCommand(handTotal);


            }
            else if (playerInput == 2)
            {

                sendBack.standCommand(handTotal);

            }
            else if (playerInput == 3)
            {
                Console.Clear();
                // mainScreen.playerChoice();

            }


        }


    }
}
