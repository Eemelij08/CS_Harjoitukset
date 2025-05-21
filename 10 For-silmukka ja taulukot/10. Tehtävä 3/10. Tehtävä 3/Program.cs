using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int sum = 0;

            for (int i = 1; i <=100; i++)
            {
                sum += i;
                Console.WriteLine($"{sum}");
            }
        }
    }
}
