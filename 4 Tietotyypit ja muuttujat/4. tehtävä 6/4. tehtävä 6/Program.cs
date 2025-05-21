using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.tehtävä_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;


            // Kysytään käyttäjältä ympyrän säde
            Console.Write("Anna celssius aste: ");
            string input = Console.ReadLine();

            // Tarkistetaan, että syöte on kelvollinen double
            bool validInput = double.TryParse(input, out double C);

            if (validInput)
            {
                // Lasketaan ympyrän ala
                double aste = C * 9 / 5 + 32;

                // Tulostetaan ympyrän ala
                Console.WriteLine($"Antamasi celssius aste farenheit asteina: {aste}");
            }
            else
            {
                // Jos syöte ei ollut kelvollinen luku
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    } 
}
