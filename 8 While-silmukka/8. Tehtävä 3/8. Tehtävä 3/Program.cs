using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Anna luku: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double luku1);

            double summa =0;

            while(luku1>0 && validInput1)
            {
                summa += luku1;

                Console.WriteLine("Anna luku: ");
                 validInput1 = double.TryParse(Console.ReadLine(), out luku1);

               
                

            }
            if (!validInput1)
            {
                Console.WriteLine("Virheellinen syöte");
            }

            Console.WriteLine("Summa: "+ summa);

  
            
        }
    }
}
