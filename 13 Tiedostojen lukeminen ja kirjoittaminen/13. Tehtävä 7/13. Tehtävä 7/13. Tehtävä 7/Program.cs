using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tehtävä_7
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string tiedostonimi = @"D:\Koulu_Koodaus\13\13. Tehtävä 7\txt\päiväkirja.txt";

            Console.Write("Kirjoita merkintä: ");
            string merkinta = Console.ReadLine(); 

            
            string aikaleima = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            
            using (StreamWriter kirjoittaja = new StreamWriter(tiedostonimi, true))
            {
                kirjoittaja.WriteLine($"{aikaleima}: {merkinta}");
            }

            Console.WriteLine("Merkintä on tallennettu!");
        }
    }
}
