using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int luku in luvut)
            {
                if (luku == 4)
                {
                    Console.WriteLine("luku 4");
                }else
                {
                    Console.WriteLine("ei ole 4");
                }
            }

            
        }
    }
}
