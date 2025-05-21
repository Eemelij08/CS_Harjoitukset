using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_6_uusi
{
    internal class Program
    {
        static void Main()
        {
            int[] numerot = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            int result = CalculateSum(numerot); 
            Console.WriteLine($"Taulukon summa: {result}");
        }

        static int CalculateSum(int[] numerot)
        {
            int sum = 0;

            foreach (int num in numerot)
            {
                sum += num; 
            }

            return sum; 
        }
    }
}
