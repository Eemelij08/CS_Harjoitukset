using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] tahdet = { "*", "**", "***", "****", "*****" };

            foreach(string tahti in tahdet)
            {
                Console.WriteLine(tahti);
            }

        }
    }
}
