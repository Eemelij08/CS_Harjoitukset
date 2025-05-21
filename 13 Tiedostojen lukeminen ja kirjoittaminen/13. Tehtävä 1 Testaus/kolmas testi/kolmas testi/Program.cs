using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmas_testi
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string filePath = @"D:\Koulu_Koodaus\13\13. Tehtävä 1 Testaus\testi\lisäys.txt";
            string additionalContent = "\nTämä teksti lisättiin tiedostoon.";

            File.AppendAllText(filePath, additionalContent);

            Console.WriteLine($"Teksti on lisätty tiedostoon {filePath}");
        }
    }
}
