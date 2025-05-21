using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const double G = 9.81;
            
            

                
            Console.Write("Anna putoamis ajan arvo sekunteina: ");
            string input = Console.ReadLine();

                
            bool validInput = double.TryParse(input, out double t);

            if (validInput)
            {
                    
                double matka = 1.0/2 * G * t * t;

                    
                Console.WriteLine($"Putoamismatka: {matka}");
            }
            else
            {
                    
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
            
        }
    }
}
