using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero väliltä 1-7");

            Console.WriteLine("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Maanantai");
                    break;
                case 2:
                    Console.WriteLine("Tiistai");
                    break;
                case 3:
                    Console.WriteLine("Keskiviikko");
                    break;
                case 4:
                    Console.WriteLine("torstai");
                    break;
                case 5:
                    Console.WriteLine("Perjantai");
                    break;
                case 6:
                    Console.WriteLine("Lauantai");
                    break;
                case 7:
                    Console.WriteLine("Sunnuntai");
                    break;
                default:
                    Console.WriteLine("Anna kelvollinen numero");
                    break;
            }
        }
    }
}
