using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku:");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna toinen kokonaisluku");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            if (validInput && validInput2)
            {
                Console.WriteLine("AND: " + (luku1 & luku2));
                Console.WriteLine("OR: " + (luku1 | luku2));
                Console.WriteLine("XOR: " + (luku1 ^ luku2));
                Console.WriteLine("Vasemman siirto: " + (luku1 << luku2));
                Console.WriteLine("Oikean siirto: " + (luku1 >> luku2));

            }else
            {
                Console.WriteLine("Anna kelvollinen kokonaisluku!");
            }
        }
    }
}
