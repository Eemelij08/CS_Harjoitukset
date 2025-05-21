using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tehtävä_3
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string alkuperäinen = @"D:\Koulu_Koodaus\13\13. Tehtävä 3\Teksti\alkuperäinen.txt";
            string uusi = @"D:\Koulu_Koodaus\13\13. Tehtävä 3\Teksti\uusi.txt";

            
            if (File.Exists(alkuperäinen))
            {
                using (StreamReader lukija = new StreamReader(alkuperäinen))
                using (StreamWriter kirjoittaja = new StreamWriter(uusi))
                {
                    int rivinumero = 1;
                    string rivi;

                    while ((rivi = lukija.ReadLine()) != null)
                    {
                        kirjoittaja.WriteLine($"{rivinumero}: {rivi}");
                        rivinumero++;
                    }
                }

                Console.WriteLine("Tiedosto on nyt käsitelty ja tallennettu.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }
}
