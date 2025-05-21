using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nimi = new List<string>() { "Anna", "Matti", "Liisa", "Pekka", "Eemeli" };

            Console.WriteLine("Syötä nimesi: ");
            string syote = Console.ReadLine();

            if (nimi.Contains(syote))
            {
                Console.WriteLine("Nimesi on listassa!");
            }
            else
            {
                Console.WriteLine("Nimeäsi ei löydy listasta.");
            }
        }
    }
}
