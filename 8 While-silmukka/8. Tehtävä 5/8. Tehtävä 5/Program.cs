using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Tehtävä_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int laskuri = 0;
            int luku1 = 0, luku2 = 1;
            

            while (laskuri <5)
            {
                Console.WriteLine(luku1);
                    Console.WriteLine(luku2);
                luku1 = luku1 + luku2;
                luku2 = luku2 + luku1;
                laskuri++;
                continue;


            }
  
        }
    }
}
