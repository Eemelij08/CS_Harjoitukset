using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double vasenX = 0;
            const double oikeaX = 10;
            const double ylaY = 10;
            const double alaY = 0;

            Console.WriteLine("Syötä pisteen x: ");
            bool validInput = double.TryParse(Console.ReadLine(), out double x);

            Console.WriteLine("Syötä pisteen y: ");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double y);

            if (validInput && validInput2)
            {
                if  (x <= oikeaX && x >= vasenX && y >= alaY && y <= ylaY) { 
                    Console.WriteLine("Piste on suorakulmon sisälä");
                   }
                
                else 
                {
                    Console.WriteLine("Piste ei ole suorakulmion sisällä");
                }
                
                     
                

                
            }else
            {
                Console.WriteLine("Anna kelvollinen luku");
            }
        }
    }
}
