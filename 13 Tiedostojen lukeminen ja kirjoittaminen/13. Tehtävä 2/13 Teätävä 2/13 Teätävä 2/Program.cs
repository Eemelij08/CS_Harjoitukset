using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Teätävä_2
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string alkuperäinen = @"D:\Koulu_Koodaus\13\13. Tehtävä 2\teksti\tämä.txt"; 
            string kopio = @"D:\Koulu_Koodaus\13\13. Tehtävä 2\teksti\kopio.txt";

            
            if (File.Exists(alkuperäinen))
            {
                
                string sisältö = File.ReadAllText(alkuperäinen);

                
                File.WriteAllText(kopio, sisältö);

                Console.WriteLine("Tiedosto kopioitu onnistuneesti.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }
}
