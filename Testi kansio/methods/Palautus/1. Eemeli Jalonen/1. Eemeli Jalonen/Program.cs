using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Eemeli_Jalonen
{
    internal class Program
    {
        static int LaskeSumma(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            return summa;
        }

        static void Main()
        {
            Console.WriteLine("Syötä kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Syötä toinen kokonaisluku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            int tulos = LaskeSumma(luku1, luku2);
            Console.WriteLine($"Summa on: {tulos}");
        }
    }
}
