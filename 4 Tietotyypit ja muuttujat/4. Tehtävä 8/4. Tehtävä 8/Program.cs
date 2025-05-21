using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tehtävä_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const double P = 1.225;
            const double G = 9.81;

            

            Console.Write("Anna korkeuden muutos: ");
            string input = Console.ReadLine();

            
            bool validInput = double.TryParse(input, out double h);

            if (validInput)
            {
                
                double muutos = P * G * h;

                
                Console.WriteLine($"paineen muutos on: {muutos}");
            }
            else
            {
                
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }
            
        }
    }
}
