using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Array.Sort(luvut);

            foreach (int luku in luvut)
            {
                Console.WriteLine(luku);
            }
        }
    }
}
