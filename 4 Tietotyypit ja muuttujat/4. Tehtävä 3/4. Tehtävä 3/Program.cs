using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Console.Write("Anna suorakulmion leveys metreinä: ");
            string input = Console.ReadLine();

             bool validInput1 = double.TryParse(input, out double leveys);

            Console.Write("Anna suorakulmion korkeus metreinä: ");
            string input2 = Console.ReadLine();

            bool validInput2 = double.TryParse(input2, out double korkeus);

            if (validInput1 && validInput2)
            {
                
                double ala = leveys * korkeus;

                
                Console.WriteLine($"Suorakulmion pinta ala on: {ala}");
            }
            else
            {
                
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
            
        }
    }
}
