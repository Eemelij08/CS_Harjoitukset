using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_11_testi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> kauppa = new List<string>();

            Console.WriteLine("Kirjoita: ");
                string lisää = Console.ReadLine();
            kauppa.Add(lisää);

            foreach(string lis in kauppa)
            {
                Console.WriteLine(lis);
            }
        }
    }
}
