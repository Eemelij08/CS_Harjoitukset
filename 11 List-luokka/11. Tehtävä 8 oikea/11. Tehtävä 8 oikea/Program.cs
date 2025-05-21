using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_8_oikea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() {"Eemeli", "Anna", "Matti", "Liisa", "pekka"};

            Console.WriteLine("Anna nimi: ");
            string nimi = Console.ReadLine();

            Console.WriteLine("Anna uusi nimi: ");
            string uus = Console.ReadLine();

            if (lista.Contains(nimi))
            {
                int index = lista.IndexOf(nimi);
                lista[index] = uus;
            }

            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        
        
        }
    }
}
