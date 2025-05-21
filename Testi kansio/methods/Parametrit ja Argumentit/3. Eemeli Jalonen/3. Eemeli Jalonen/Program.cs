using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Eemeli_Jalonen
{
    internal class Program
    {


        // Metodi, joka ottaa yhden parametrin
        static void TulostaTervehdys(string nimi)
        {
            Console.WriteLine($"Hei, {nimi}!");
        }

        
        static void Main()
        {
            Console.WriteLine("Kerro nimesi: ");
            string nimi = Console.ReadLine();


            
            Console.WriteLine($"Hei {nimi}!");
        }

       

    }
}
