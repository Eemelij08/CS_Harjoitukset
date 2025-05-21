using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            
            
            Console.Write("Anna ympyrän halkaisija:");
            string input = Console.ReadLine();

            bool validinput = double.TryParse(input, out double halkaisija);

            if (validinput)
            {
                double ala = PI*halkaisija;

                Console.WriteLine($"Ympyrän ympärysmitta on {ala}");

            }
            else
            {
                Console.WriteLine("Virheellinen syöte. anna kelvolinen luku.");
            }
            
        }
    }
}
