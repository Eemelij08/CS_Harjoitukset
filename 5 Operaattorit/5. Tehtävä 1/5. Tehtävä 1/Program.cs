using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna toinen kokonaisluku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            if (validInput1 && validInput2)
            {
                Console.WriteLine("Kokonaislukujen summa: " + (luku1 + luku2));
                Console.WriteLine("Kokonaislukujen erotus: " + (luku1 - luku2));
                Console.WriteLine("Kokonaislukujen tulo: " + (luku1 * luku2));
                Console.WriteLine("Kokonaislukujen osamäärä: " + (luku1 / luku2));
                Console.WriteLine("Kokonaislukujen jakojäännös: " + (luku1 % luku2));
            
            }
            else
            {

                Console.WriteLine("Virheellinen syöte"); 
            
            }   

            


        }
    }
}
