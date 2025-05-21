using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool ValidInput = int.TryParse(Console.ReadLine(), out int luku1);

                if (luku1 % 2 == 0) 
                {
                    Console.WriteLine("Lukusi on parillinen");
                }
                    else
                    {
                    Console.WriteLine("Lukusi on pariton");

                    }

                        if (luku1 % 3 == 0)
                        { Console.WriteLine("Lukusi on jaollinen 3:lla");
                        
                        }


                         else { Console.WriteLine("Lukusi ei ole jaollinen 3:lla"); }
            
        }
    }
}
