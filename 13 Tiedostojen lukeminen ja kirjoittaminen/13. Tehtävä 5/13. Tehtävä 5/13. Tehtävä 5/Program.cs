using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tehtävä_5
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string tiedostonimi = @"D:\Koulu_Koodaus\13\13. Tehtävä 5\teksti\rivi.txt";

            
            if (File.Exists(tiedostonimi))
            {
                int rivimaara = 0;

                using (StreamReader lukija = new StreamReader(tiedostonimi))
                {
                    while (lukija.ReadLine() != null) 
                    {
                        rivimaara++;
                    }
                }

                Console.WriteLine($"Tiedostossa on {rivimaara} riviä.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }

}
