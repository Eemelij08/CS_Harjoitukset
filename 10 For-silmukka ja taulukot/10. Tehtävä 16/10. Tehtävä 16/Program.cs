using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , ] numerot = { { 1, 2, 3, }, {4,5,6 }, {7,8,9 } };

            for (int i = 0; i < numerot.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j<numerot.GetLength(1); j++)
                {
                    Console.Write(numerot[i, j]+" ");
                    
                }
            }
            
            

       
        }
    }
}
