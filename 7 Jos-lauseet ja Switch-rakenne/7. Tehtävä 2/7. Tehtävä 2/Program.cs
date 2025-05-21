using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku:");
            bool validInput = double.TryParse(Console.ReadLine(), out double luku1);

            if (validInput)
            {
                if (luku1 > 0)
                {
                    Console.WriteLine("Luku on positiivinen");

                }
                else if (luku1 < 0)
                {
                    Console.WriteLine("Luku on negatiivinen");

                }
                else
                {
                    Console.WriteLine("Luku on 0");
                }


            }else
            {
                Console.WriteLine("Anna kelvollinen luku!");
            }
        }
    }
}
