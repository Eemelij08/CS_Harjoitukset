using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku);

            PrintTriangle(luku);
        }
    
        static void PrintTriangle(int n)
        {
            
            
            for (int i = 1; i <=n;i++)
            {
                Console.WriteLine(new string('*', i));
            }

        }

    
    
    }
}
