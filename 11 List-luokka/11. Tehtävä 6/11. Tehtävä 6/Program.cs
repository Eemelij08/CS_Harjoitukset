using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> luku = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            luku.Reverse();
            foreach (int i in luku)
            {
                
                Console.WriteLine(i);
  
            }
            luku.Sort();
            Console.WriteLine(" ");
            foreach (int i2 in luku)
            {
                
                Console.WriteLine(i2);

            }
        
        }
    }
}
