using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tehtävä_8
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string tiedostonimi = @"D:\Koulu_Koodaus\13\13. Tehtävä 8\teksti\montako.txt";

            Console.Write("Kirjoita sana jota etsit tiedostosta: ");
            string sana = Console.ReadLine();

            if (File.Exists(tiedostonimi))
            {
                string sisalto = File.ReadAllText(tiedostonimi); 
                int laskuri = 0;
                int indeksi = 0;

                while ((indeksi = sisalto.IndexOf(sana, indeksi, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    laskuri++;
                    indeksi += sana.Length;
                }

                Console.WriteLine($"Sana esiintyy tiedostossa {laskuri} kertaa.");
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löytynyt.");
            }
        }
    }
}
