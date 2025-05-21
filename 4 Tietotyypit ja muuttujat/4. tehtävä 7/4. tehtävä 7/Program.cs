using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.tehtävä_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;



            
            Console.Write("Anna sekuntien määrä: ");
            string input = Console.ReadLine();

            
            bool validInput = double.TryParse(input, out double sekunnit);

            if (validInput)
            {

                double tunnit = sekunnit / 3600;
                double minuutit = sekunnit / 60;

                
                Console.WriteLine($"Sekunnit tunteina: {tunnit}");
                Console.WriteLine($"Sekunnit minuutteina: {minuutit}");
                Console.WriteLine($"Antamasi sekunnit: {sekunnit}");
            }
            else
            {
                
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
