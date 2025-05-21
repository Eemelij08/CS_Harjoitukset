using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> testia = new List<int>() { 1, 2, 3, 4, 5};
            List<int> testib = new List<int>() { 6,4,5,7,7 };
            List<int> yhdistetty = testia.Union(testib).ToList();
            
            
            

            foreach (int i in yhdistetty)
            {
                Console.WriteLine(i);
            }
        }
    }
}
