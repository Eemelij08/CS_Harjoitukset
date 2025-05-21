using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);

            if (validInput)
            {
                if (luku1 % 2 == 0)
                {
                    Console.WriteLine("Parillinen");

                    
                }else
                {
                    Console.WriteLine("Pariton");
                }
            }else
            {
                Console.WriteLine("Syötä kelvollinen luku!");
            }
        }
    }
}
