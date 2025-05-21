using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_13_uus_yritys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna yhden sivun pituus: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double luku1);

            Console.WriteLine("Anna toisen sivun pituus: ");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double luku2);

            Console.WriteLine("Anna kolmannen sivun pituus: ");
            bool validInput3 = double.TryParse(Console.ReadLine(), out double luku3);

            if (validInput1 && validInput2 && validInput3)
            {
                if (luku1 == luku2 && luku2 == luku3)
                    Console.WriteLine("Tasasivuinen kolmio");



                else if (luku1 == luku2 || luku2 == luku3 || luku1 == luku3)
                {
                    Console.WriteLine("Tasakylkinen kolmio");



                }
                else if (luku1 * luku1 + luku2 * luku2 == luku3 * luku3)
                {
                    Console.WriteLine("Suorakulmainen kolmio");
                }
                else
                {
                    Console.WriteLine("Epäsäännöllinen kolmio");
                }
            }else
            {
                Console.WriteLine("Anna kelvollinen syöte");
            }
        }
    }
}
