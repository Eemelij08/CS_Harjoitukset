using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nimi = new List<string>() { "Pekka", "Liisa", "Matti", "Anna", "Eemeli" };

            nimi.Sort();
            

            foreach(string x in nimi)
            {
                Console.WriteLine(x);
            }



        }
    }
}
