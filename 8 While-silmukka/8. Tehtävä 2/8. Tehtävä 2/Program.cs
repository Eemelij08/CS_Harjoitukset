using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int luku1 = 0;
            while (luku1<100)
            {
                luku1++;
                if (luku1 % 2 == 1)
                    continue;
                Console.WriteLine(luku1);
            }
        }
    }
}
