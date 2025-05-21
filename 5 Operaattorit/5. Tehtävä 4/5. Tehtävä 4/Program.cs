using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku: ");
            bool validInput = double.TryParse(Console.ReadLine(), out double luku1);

            if(validInput)
            {
                Console.WriteLine("Lukusi kun siihen on lisätty 5: " + (luku1 += 5));
                Console.WriteLine("Lukusi kun se on kerrottu 2:lla: " + (luku1 *= 2));
                Console.WriteLine("Lukusi kun se on jaettu 3:lla: " + (luku1 /= 3));
            }
            else
            {
                Console.WriteLine("Anna kunnollinen luku!!");
            }

        }
    }
}
