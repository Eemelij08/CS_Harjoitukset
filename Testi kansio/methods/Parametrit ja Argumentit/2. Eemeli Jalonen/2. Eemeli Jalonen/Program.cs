using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Eemeli_Jalonen
{
    internal class Program
    {
        
        
            static int LaskeYks(int luku1)
            {
                int tulo = luku1 + 1;
                return tulo;
            }

            static void Main()
            {
                Console.WriteLine("Syötä kokonaisluku: ");
                bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);



                int tulos = LaskeYks(luku1);
                Console.WriteLine($"yhden suurempi on: {tulos}");
            }
        
    }
}
