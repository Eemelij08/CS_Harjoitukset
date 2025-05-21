using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double luku1);

            Console.WriteLine("Anna toinen luku");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double luku2);
            if (validInput1 && validInput2) {

            Console.WriteLine("Valitse millä tavalla haluat laskea:");
            Console.WriteLine("1 on +");
            Console.WriteLine("2 on -");
            Console.WriteLine("3 on *");
            Console.WriteLine("4 on /");

            Console.WriteLine("Syötä valinta");
                int valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.WriteLine("Lukujen summa on " + (luku1 + luku2));
                        break;
                    case 2:
                        Console.WriteLine("Lukujen erotus on " + (luku1 - luku2));
                        break;
                    case 3:
                        Console.WriteLine("Lukujen tulo on " + (luku1 - luku2));
                        break;
                    case 4:
                        Console.WriteLine("Lukujen jako on " + (luku1 / luku2));
                        break;
                    default:
                        Console.WriteLine("Anna kelvollinen luku");
                        break;
                }
                }else
            {
                Console.WriteLine("Anna kelvollinen luku");
            }




        }
    }
}
