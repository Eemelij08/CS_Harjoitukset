using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kappaleen_koodi_testi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä sinun ikäsi:");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Sinun ikäsi on " + age + "vuotta.");
        }
    }
}
