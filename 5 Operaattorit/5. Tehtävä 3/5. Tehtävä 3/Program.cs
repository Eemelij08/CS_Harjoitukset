using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen totuusarvo (true/false): ");
            bool validInput = bool.TryParse(Console.ReadLine(), out bool a);
            Console.WriteLine("Anna toinen totuusarvo (true/false): ");
            bool validInput2 = bool.TryParse(Console.ReadLine(), out bool b);
            
            if (validInput && validInput2)
            {
                Console.WriteLine("AND: " + (a && b));
                Console.WriteLine("OR: " + (a || b));
                Console.WriteLine("NOT (ensimmäinen): " + (!a));


            }
            else
            {
                Console.WriteLine("Anna kelvollinen syöte!");
            }
        }
    }
}
