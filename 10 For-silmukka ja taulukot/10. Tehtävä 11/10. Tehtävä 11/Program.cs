using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

                int[] numerot = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                int max = numerot.Max();
                int min = numerot.Min();

                Console.WriteLine(max);
                Console.WriteLine(min);
            
        }
    }
}
