using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            bool oikein = false;

            Console.WriteLine("Arvaa luku välilä 1 - 100 ");
            


            while (!oikein)
            {
                Console.WriteLine("Arvaus: ");
                bool validInput = int.TryParse(Console.ReadLine(), out int arvaus);



              

                if (arvaus < secretNumber)
                {
                    Console.WriteLine("Liian pieni");
                }
                else if (arvaus > secretNumber)
                {
                    Console.WriteLine("Liian suuri");
                }
                else
                {
                    oikein = true;
                    Console.WriteLine("Arvasit luvun oikein!");
                }



            }



        }
    }
}
