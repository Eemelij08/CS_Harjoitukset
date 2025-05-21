using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Salasana = "Salasana";
            int numero = 0;
            do
            {
                Console.Write("Syötä Salasana: ");
                string sala = Console.ReadLine();

                if (Salasana == sala)
                {
                    numero++;
                    
                }

            } while (numero<1);
            Console.WriteLine("Syötit salasanan oikein");
            
            
        }
    }
}
