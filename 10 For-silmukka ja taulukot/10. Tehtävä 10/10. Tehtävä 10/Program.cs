using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Tehtävä_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);

            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput3 = int.TryParse(Console.ReadLine(), out int luku3);

            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput4 = int.TryParse(Console.ReadLine(), out int luku4);

            Console.WriteLine("Anna kokonaisluku: ");
            bool validInput5 = int.TryParse(Console.ReadLine(), out int luku5);

            if (validInput1 && validInput2 && validInput3 && validInput4 && validInput5)
            {
                int[] luvut = new int[5];

                // Asetetaan arvot taulukkoon
                luvut[0] = luku1;
                luvut[1] = luku2;
                luvut[2] = luku3;
                luvut[3] = luku4;
                luvut[4] = luku5;

            // Tulostetaan taulukon arvot
            Console.WriteLine($"Ensimmäinen arvo: {luvut[0]}");
                Console.WriteLine($"Toinen arvo: {luvut[1]}");
                Console.WriteLine($"Kolmas arvo: {luvut[2]}");
                Console.WriteLine($"Neljäs arvo: {luvut[3]}");
                Console.WriteLine($"Viides arvo: {luvut[4]}");

            }

      
        }
    }
}
