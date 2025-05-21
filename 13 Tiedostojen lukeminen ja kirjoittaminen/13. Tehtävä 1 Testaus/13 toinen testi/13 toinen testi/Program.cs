using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_toinen_testi
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string filePath = @"D:\Koulu_Koodaus\13\13. Tehtävä 1 Testaus\testi\testi.txt";

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("Tiedoston sisältö:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath} ei löytynyt.");
            }
        }
    }
}
