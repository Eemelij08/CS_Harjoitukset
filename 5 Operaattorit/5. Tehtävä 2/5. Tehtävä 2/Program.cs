using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna toinen kokonaisluku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            if(validInput && validInput2)
            {
                Console.WriteLine("Onko luvut yhtä suuria? " + (luku1 == luku2));
                Console.WriteLine("Onko ensimmäinen luku suurempi kuin toinen luku? " + (luku1 > luku2));
                Console.WriteLine("Onko ensimmäinen luku pienempi kuin toinen luku? " + (luku1 < luku2));

               
            }
            else
            {
                Console.WriteLine("Anna kokonaisluku");
            }
        }
    }
}
