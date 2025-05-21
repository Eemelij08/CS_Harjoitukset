using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_5
{
    internal class Program
    {
        static int IsEven(int luku1)
        {
            int summa = luku1;
            return summa;  // Palauttaa laskutuloksen
        }

        static void Main()
        {
            Console.WriteLine("Syötä kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            if(luku1 % 2 ==0) {
                Console.WriteLine("Luku on parillinen!");
            }else
            {
                Console.WriteLine("Luku on pariton!");
            }

            
        }
    }
}
