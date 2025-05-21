using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna arvo: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double luku1);

            Console.WriteLine("Anna toinen arvo:");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double luku2);

            Console.WriteLine("Anna kolmas arvo: ");
            bool validInput3 = double.TryParse(Console.ReadLine(), out double luku3);

            if (validInput1 && validInput2 && validInput3)
            {
                if (luku1+luku2>luku3 && luku1+luku3>luku2 && luku2+luku3>luku1)
                {
                    Console.WriteLine("Antamasi luvut muodostavat kolmion!");
                }else
                {
                    Console.WriteLine("Antamasi luvut eivät muodosta kolmiota");
                }
            }else
            {
                Console.WriteLine("Anna kelvolliset arvot");
            }
        }
    }
}
