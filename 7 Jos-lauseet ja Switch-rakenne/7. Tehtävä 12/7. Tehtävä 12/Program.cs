using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string nimi = "Nimi";
            const string sala = "Salasana";

            Console.WriteLine("Syötä käyttäjä tunnus: ");
            string tunnus = Console.ReadLine();

            Console.WriteLine("Syötä salasana: ");
            string salasana = Console.ReadLine();

            if (tunnus == nimi && salasana == sala)
            {
                Console.WriteLine("Pääsy käyttäjätietoihin");
            }else
            {
                Console.WriteLine("Salasana tai käyttäjä tunnus virheellinen");
            }
        }
    }
}
