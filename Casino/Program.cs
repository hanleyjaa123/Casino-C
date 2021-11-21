using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    public class Program
    {
        static public void Main(string[] args)
        {
            string mainTitle = @"



  ______                       __                     
 /      \                     /  |                    
/$$$$$$  |  ______    _______ $$/  _______    ______  
$$ |  $$/  /      \  /       |/  |/       \  /      \ 
$$ |       $$$$$$  |/$$$$$$$/ $$ |$$$$$$$  |/$$$$$$  |
$$ |   __  /    $$ |$$      \ $$ |$$ |  $$ |$$ |  $$ |
$$ \__/  |/$$$$$$$ | $$$$$$  |$$ |$$ |  $$ |$$ \__$$ |
$$    $$/ $$    $$ |/     $$/ $$ |$$ |  $$ |$$    $$/ 
 $$$$$$/   $$$$$$$/ $$$$$$$/  $$/ $$/   $$/  $$$$$$/  
                                                      
                                                      
                                                      





";

            Console.WriteLine(mainTitle);
            Console.WriteLine("Click the any key to continue");
            Console.ReadKey();
            playerChoice();



            
        }

        static void playerChoice()
        {
            Console.Clear();
            blackjackGame class1 = new blackjackGame();

            int userInput = -1;

            while (userInput == -1)
            {
                Console.WriteLine("What game would you like to play?");
                Console.WriteLine("1. Blackjack");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput != 1)
                {
                    Console.Clear();
                    userInput = -1;
                }
                else if (userInput == 1)
                {
                    Console.Clear();
                    class1.playBlackJack();
                }

            }
            
            Console.ReadKey();



        }



    }
}
