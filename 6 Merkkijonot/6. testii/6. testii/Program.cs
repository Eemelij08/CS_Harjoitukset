using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.testii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double luku = 1234.5648;

            Console.WriteLine($"Luku: {luku:F2}"); // Tulostaa 1234.57
        Valuutta:

            double hinta = 100;
            Console.OutputEncoding = Encoding.Default; // jos ongelma €-merkin tulostuksessa

            Console.WriteLine($"Hinta: {hinta:C}"); // Tulostaa esim. €99.99 (kieliasetuksista riippuen)


            DateTime paivamaara = DateTime.Now;

            Console.WriteLine($"Tänään on: {paivamaara:dd.MM.yyyy}"); // Tulostaa esim. 10.01.2025
            Console.WriteLine($"Kellonaika: {paivamaara:HH:mm:ss}");   // Tulostaa esim. 14:30:45
        }
    }
}
