using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_toinen_tehtävä_uusin_tällä_hetkellä
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kokonaisluku:");


            // Luetaan käyttäjän syöte merkkijonona ja muunnetaan kokonaisluvuksi
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Syötä toinen kokonaisluku:");

            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            if (validInput1 && validInput2)
            {


                int summa = luku1 + luku2;
                int erotus = luku1 - luku2;
                int tulo = luku1 * luku2;

                Console.WriteLine("Kokonaislukujen summa on " + summa);
                Console.WriteLine("Kokonaislukujen erotus on " + erotus);
                Console.WriteLine("kokonaislukujen tulo on " + tulo);
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen kokonaisluku");
            }
        }
    }
}
