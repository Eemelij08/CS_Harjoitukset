using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tehtävä_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kerto = 1;
            int hassutus = 1;
            Console.WriteLine("Syötä kokonaisluku: ");
            bool validInput = double.TryParse(Console.ReadLine(), out double luku1);

            while(kerto<11 && validInput)
            {
                Console.WriteLine("Lukusi kerrottu "+hassutus+": " + luku1 * kerto);
                hassutus++;
                kerto++;
                continue;
                
            }
            if (!validInput)
            {
                Console.WriteLine("Anna kelvollinen luku!");
            }
            

            
        }
    }
}
