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
            // creates a varible thats equals a random number generator 1-10 
            int num01 = random.Next(1, 11);
            int num02 = random.Next(1, 11);
            int handTotal = num01 + num02; // takes the two random numbers previously generated, and adds them for a total.


            while (handTotal < 21) 
            {  // while --> handTotal is less than 21, read code below.
                Console.Clear(); 

                Console.WriteLine("your hand is: " + handTotal);
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Stand");
                Console.WriteLine("3. Return to menu");
               int playerInput = Convert.ToInt32(Console.ReadLine());

                if (playerInput == 1) // if statments, checking players input. if anything except a int is inputed, the application will brake. 
                {
                    // [HIT COMMAND] takes the handTotal, and sets it equal to handTotal + a random number 1-10
                    handTotal = handTotal + random.Next(1, 11); 
                    if (handTotal > 21) // checks to see if the handTotal went over 21, if true code below is ran.
                    {
                        Console.WriteLine("you busted! your total was: " + handTotal);
                        Console.ReadKey();
                        playBlackJack();
                    }




                }
                else if (playerInput == 2)
                {
                    Console.Clear();
                    Console.WriteLine("your total is: " + handTotal);
                    // there is 100% a better way to do this, just gotta figure out how. When the player stands, it will then generate the dealers hand, and get dealers total.
                    int d01 = random.Next(1, 11);
                    int d02 = random.Next(1, 11);
                    int dealerTotal = d01 + d02;



                    Console.WriteLine("the dealers total is: " + dealerTotal); // after generating the dealers hand, it will be displayed for the user.

                    if (handTotal > dealerTotal) // logic checks, seeing which hand between the two won. 
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
                else if (playerInput == 3) // last input to return to main menu.
                {
                    


                }

            } 


            

            

        }












    }
}
