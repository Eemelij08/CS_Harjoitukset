using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_3
{
    internal class Program
    {
        // Metodi, joka ottaa yhden parametrin
        static void square(int luku)
        {
            Console.WriteLine($"Kokonaisluku neliönä{luku*luku}!");
        }

       

        static void Main()
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku);
            
            square(luku);
        }
    }
}
