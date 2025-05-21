using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            bool validInput = double.TryParse(Console.ReadLine(), out double luku1);
            

            if (validInput)
            {
                string result = (luku1 > 0) ? "Positiivinen" : (luku1 < 0) ? "Negatiivinen" : "Nolla";
                Console.WriteLine(result);
                
            }
        }
    }
}
