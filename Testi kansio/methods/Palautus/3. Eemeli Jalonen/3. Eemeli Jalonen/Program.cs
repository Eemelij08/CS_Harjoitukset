using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Eemeli_Jalonen
{
    internal class Program
    {
        static void Vika(string nimi)
        {
            if (nimi.Length > 0)
            {
                Console.WriteLine(nimi[nimi.Length - 1]);
            }
        
            
        
        }

        static void Main()
        {

            Console.WriteLine("Kerro nimesi");
            string name = Console.ReadLine();
            Console.WriteLine("Antamasi nimen viimeinen kirjain on: ");
            Vika(name);
        }

    }
}
