using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
   public class blackjackGame
    {

        Random random = new Random();
        BlackjackLogic logic = new BlackjackLogic();

        public void playBlackJack()
        {
            

            
            
          

            int num01 = random.Next(1, 11);
            int num02 = random.Next(1, 11);
            int d01 = random.Next(1, 11); // creates dealers first card
            int handTotal = num01 + num02; // takes the two random numbers previously generated, and adds them for a total.


  
            while (handTotal < 21) 
            {  // while --> handTotal is less than 21, read code below.
                Console.Clear();

                Console.WriteLine("Dealers first card: " + d01);
                Console.WriteLine("");
                Console.WriteLine("your hand is: " + handTotal);
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Stand");
                Console.WriteLine("3. Return to menu");
               int playerInput = Convert.ToInt32(Console.ReadLine());
                logic.menuCheck(playerInput, handTotal, d01);


                if (playerInput == 1) // if statements, checking players input. if anything except a int is inputed, the application will brake. 
                {


                   



                }
                else if (playerInput == 2) // [STAND COMMAND]
                {
                   
                    





                }
                else if (playerInput == 3) // last input to return to main menu.
                {
                    


                }

            } 


        }


        public void hitCommand(int handTotal)
        {

            // [HIT COMMAND] takes the handTotal, and sets it equal to handTotal + a random number 1-10
            handTotal = handTotal + random.Next(1, 11);
            if (handTotal > 21) // checks to see if the handTotal went over 21, if true code below is ran.
            {
                Console.WriteLine("you busted! your total was: " + handTotal);
                Console.ReadKey();
                playBlackJack();
            } 

            // logic.menuCheck(handTotal); <--- can't figure a way to update the handTotal after adding the the random.Next

        }

             public void standCommand(int handTotal, int firstCard)
             {

                 Console.Clear();
                 Console.WriteLine("your total is: " + handTotal);
                 // there is 100% a better way to do this, just gotta figure out how. When the player stands, it will then generate the dealers hand, and get dealers total.

                 int d02 = random.Next(1, 11);

                 int dealerTotal = firstCard + d02;
                 while (dealerTotal < 17)
                 {
                     int d03 = random.Next(1, 11);
                     dealerTotal = dealerTotal + d03;

                 }


                 Console.WriteLine("the dealers total is: " + dealerTotal); // after generating the dealers hand, it will be displayed for the user.

                 logic.playerHandCheck(handTotal, dealerTotal); // when the player stands it takes all the int's from players hand and dealers hand and sends it to the Blackjack logic method on another file
                                                                // logic which is defined above then passes the var handTotal, and dealer total



             }





    }
}
