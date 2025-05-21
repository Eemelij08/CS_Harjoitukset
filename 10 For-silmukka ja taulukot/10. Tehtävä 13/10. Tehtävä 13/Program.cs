using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luku = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Array.Reverse(luku);
            
            foreach (int luvut in luku)
            {
                Console.WriteLine(luvut);
            }
        }
    }
}
