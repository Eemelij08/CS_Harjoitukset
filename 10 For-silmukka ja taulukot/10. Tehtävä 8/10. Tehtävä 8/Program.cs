using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vuodet = 10;
            double korko = 5.0;
            Console.OutputEncoding = Encoding.Default; 


            Console.WriteLine("Anna säästetty summa: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double summa);
            


            for (int i = 1; i<= vuodet; i++)
            {
                summa = summa * (1 + korko / 100);
                

                Console.WriteLine($"Vuosi: {i} Säästettu summa: {summa:C}") ;
            }
        }
    }
}
