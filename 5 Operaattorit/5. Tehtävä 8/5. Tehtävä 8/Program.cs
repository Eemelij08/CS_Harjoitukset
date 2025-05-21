using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool  validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna toinen kokonaisluku: ");
            bool  validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            Console.WriteLine("Anna kolmas kokonaisluku: ");
            bool  validInput3 = int.TryParse(Console.ReadLine(), out int luku3);

            if (validInput1 && validInput2 && validInput3)
            {
                Console.WriteLine("Kasvava järjestys: " + (luku1< luku2 && luku2 < luku3));
                Console.WriteLine("Laskeva järjestys: " + (luku1 > luku2 && luku2 > luku3));
                Console.WriteLine("Kaikki samat: " + (luku1 == luku2 && luku2 == luku3));
            }
            else
            {
                Console.WriteLine("Anna kokonaisluku!");
            }
        }
    }
}
