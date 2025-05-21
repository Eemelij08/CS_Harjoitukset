using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> luvut = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int summa = luvut.Take(10).Sum();

            Console.WriteLine(summa);
        }
    }
}
