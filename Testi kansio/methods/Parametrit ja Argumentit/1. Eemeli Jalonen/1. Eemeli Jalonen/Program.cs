using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Eemeli_Jalonen
{
    internal class Program
    {
       
            static int LaskeTulo(int luku1)
            {
                int tulo = luku1 * luku1;
                return tulo;
            }

         static void Main()
           {
            Console.WriteLine("Syötä kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            

            int tulos = LaskeTulo(luku1);
            Console.WriteLine($"Tuplaus on: {tulos}");
           }
        
    }
}
