using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä ikäsi: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int ika);

            if (validInput)
            {
                if (ika >= 18)
                {
                    Console.WriteLine("Olet aikuinen");

                } else if (ika <= 17 && ika >= 0)
                {
                    Console.WriteLine("Olet nuori");
                }else
                {
                    Console.WriteLine("Anna kelvollinen ikä!");
                }
            }
            else
            {
                Console.WriteLine("Anna kelvollinen ikä!");
            }
        }
    }
}
