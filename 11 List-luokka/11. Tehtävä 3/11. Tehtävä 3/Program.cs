using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna kokonaisluku: ");
            int.TryParse(Console.ReadLine(), out int luku2);

            Console.WriteLine("Anna kokonaisluku: ");
            int.TryParse(Console.ReadLine(), out int luku3);

            Console.WriteLine("Anna kokonaisluku: ");
            int.TryParse(Console.ReadLine(), out int luku4);

            Console.WriteLine("Anna kokonaisluku: ");
            int.TryParse(Console.ReadLine(), out int luku5);

            List<int> luvut = new List<int>() { luku1, luku2, luku3, luku4, luku5 };

            int suurin = luvut.Max();

            int pienin = luvut.Min();

            Console.WriteLine("Suurin kokonailuku: "+ suurin);
            Console.WriteLine("Pienin kokonaisluku "+ pienin);
        }
    }
}
