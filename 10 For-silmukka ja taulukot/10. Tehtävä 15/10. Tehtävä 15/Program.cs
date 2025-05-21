using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 1, 3, 5, 7, 9 };
            int[] taulukko2 = { 2, 4, 6, 8, 10 };
            int[] yhdistetty = new int[taulukko1.Length + taulukko2.Length];

            Array.Copy(taulukko1,yhdistetty,taulukko1.Length);
            Array.Copy(taulukko2, 0, yhdistetty, taulukko1.Length, taulukko2.Length);
            Array.Sort(yhdistetty);
            foreach (int uutuus in yhdistetty)
            {
                Console.Write(" "+uutuus+" ");
            }
        }
    }
}
