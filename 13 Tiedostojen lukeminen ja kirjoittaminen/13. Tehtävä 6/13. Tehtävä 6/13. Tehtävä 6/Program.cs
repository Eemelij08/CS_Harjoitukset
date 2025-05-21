using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tehtävä_6
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string tiedostonimi = @"D:\Koulu_Koodaus\13\13. Tehtävä 6\Teksti tänne\numero.txt";

            
            if (File.Exists(tiedostonimi))
            {
                int sanamaara = 0;

                using (StreamReader lukija = new StreamReader(tiedostonimi))
                {
                    string rivi;

                    while ((rivi = lukija.ReadLine()) != null) 
                    {
                        
                        string[] sanat = rivi.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        sanamaara += sanat.Length; 
                    }
                }

                Console.WriteLine($"Tiedostossa on {sanamaara} sanaa.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }

}
