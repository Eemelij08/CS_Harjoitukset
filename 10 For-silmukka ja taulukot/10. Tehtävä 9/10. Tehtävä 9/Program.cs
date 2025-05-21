using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[5];
            taulukko[0] = 1;
            taulukko[1] = 2;
            taulukko[2] = 3;
            taulukko[3] = 4;
            taulukko[4] = 5;

            Console.WriteLine($"Ensimmäinen arvo: {taulukko[0]}");
            Console.WriteLine($"Toinen arvo: {taulukko[1]}");
            Console.WriteLine($"Kolmas arvo: {taulukko[2]}");
            Console.WriteLine($"Neljäs arvo: {taulukko[3]}");
            Console.WriteLine($"Viides arvo: {taulukko[4]}");

        }
    }
}
