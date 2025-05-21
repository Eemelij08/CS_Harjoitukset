using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_kappaleen_koodi_testi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Syötteen lukeminen
            Console.WriteLine("Syötä nimesi:");
            string name = Console.ReadLine();


            Console.WriteLine("Syötä ikäsi:");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Syötä pituutesi:");
            double height = double.Parse(Console.ReadLine());


            // Tulostetaan kaikki syötetyt tiedot
            Console.WriteLine("Moi " + name + "!");
            Console.WriteLine("Olet " + age + " vuotta vanha.");
            Console.WriteLine("Sinun pituutesi on " + height + " cm");
        }
    }
}
