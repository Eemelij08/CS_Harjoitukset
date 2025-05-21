using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> luvut = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var pariton = luvut.Where(x => x % 2 != 0);

            foreach (var x in pariton)
            {
                Console.WriteLine(x);
            }

            
        }
    }
}
