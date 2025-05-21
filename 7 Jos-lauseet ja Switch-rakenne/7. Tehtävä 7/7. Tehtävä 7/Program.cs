using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita merkkijono: ");
            string sana1 = Console.ReadLine();

            Console.WriteLine("Kirjoita vielä toinen merkkijono: ");
            string sana2 = Console.ReadLine();

            if (sana1 == sana2)
            {
                Console.WriteLine("Kirjoitit kaksi samaa merkkijonoa.");
            }else
            {
                Console.WriteLine("Et kirjoittanut kahta samaa merkkijonoa.");
            }
        }
    }
}
