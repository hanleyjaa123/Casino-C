using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    class Program
    {
        static void Main(string[] args)
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
            Console.Clear();



            Console.WriteLine("What game would you like to play?");
            Console.WriteLine("1. Blackjack");
           string Input = Console.ReadLine();
            Class1 class1 = new Class1();

            if (Input == "1")
            {
                Console.WriteLine("blackjack");
                class1.gameMechanic();
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("nope");
                Console.ReadKey();
                
            }



        }



    }
}
