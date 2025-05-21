using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _10.Tehtävä_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maara = 0;
            double summa = 0.0;
            double keski = 0.0;
            int[] numerot = { 10, 20, 30, 40 };
            

            maara = numerot.Count();

            for (int i = 0; i < numerot.Length; i++) 
            {
                summa += numerot[i];

                keski = summa / maara;

                Console.WriteLine(keski);
            }

        }
    }
}
