using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna toinen kokonaisluku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            Console.WriteLine("Anna kolmas kokonaisluku");
            bool validInput3 = int.TryParse(Console.ReadLine(),out int luku3);


            if (validInput1 && validInput2 && validInput3)
            {
                if (luku1 > luku2 && luku2 > luku3)
                {
                    Console.WriteLine("Ensimmäinen kokonaisluku on suurin!");

                }
                else if (luku1 < luku2 && luku2 > luku3)
                {
                    Console.WriteLine("Toinen kokonaisluku on suurin!");

                }else
                {
                    Console.WriteLine("Kolmas kokonaisluku on suurin!");
                }
            }
            else
            {
                Console.WriteLine("Anna kelvollinen kokonaisluku!");
            }
            
        }
    }
}
