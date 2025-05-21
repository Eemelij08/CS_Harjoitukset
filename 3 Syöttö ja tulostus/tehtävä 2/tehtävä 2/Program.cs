using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kokonaisluku:");


            // Luetaan käyttäjän syöte merkkijonona ja muunnetaan kokonaisluvuksi
            int luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen kokonaisluku:");

            int luku2 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;

            Console.WriteLine("Kokonaislukujen summa on " + summa);
            Console.WriteLine("Kokonaislukujen erotus on " + erotus);
            Console.WriteLine("kokonaislukujen tulo on " + tulo);

            
        }
    }
}
