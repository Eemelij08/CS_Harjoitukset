using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_9
{
    internal class Program
    {
        static void Main()
        {
            int x = 2;
            int y = 1;

            Swap(ref x, ref y);

            Console.WriteLine($"Vaihdon jälkeen: {x} {y}");
        }
    
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    
    }
}
