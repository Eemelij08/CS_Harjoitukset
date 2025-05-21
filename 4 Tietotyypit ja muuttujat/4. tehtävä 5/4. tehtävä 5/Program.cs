using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.tehtävä_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double C = 299792458;




            Console.Write("Anna aika sekunteina: ");
            string input = Console.ReadLine();


            bool validInput = double.TryParse(input, out double sekunti);

            if (validInput)
            {

                double matka = C * sekunti;

                double matka2 = matka / 1000;


                Console.WriteLine($"Valo kulkee tämän matkan: {matka2}");
            }
            else
            {

                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
