using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Tehtävä_4
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string alkuperäinen = @"D:\Koulu_Koodaus\13\13. Tehtävä 4\Teksti\alkuperä.txt"; 
            string uutuus = @"D:\Koulu_Koodaus\13\13. Tehtävä 4\Teksti\uutuus.txt"; 

           
            if (File.Exists(alkuperäinen))
            {
                
                string sisältö = File.ReadAllText(alkuperäinen);

                
                string uusiSisältö = sisältö.Replace("vanha", "uusi");

                
                File.WriteAllText(uutuus, uusiSisältö);

                Console.WriteLine("Tiedosto on nyt käsitelty ja tallennettu.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }

}
