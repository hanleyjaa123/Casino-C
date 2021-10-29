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
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            Console.ReadKey();



        }


         static void gameCards(int number)
        {
            List<int> playCards = new List<int>() { 1, 2, 5, 7, 8, 10 };

        }



    }
}
