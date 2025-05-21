using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_eka_testi
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            string filePath = "example.txt";
            string content = "Tämä on esimerkki tiedoston kirjoittamisesta.";

            File.WriteAllText(filePath, content);

            Console.WriteLine($"Teksti on kirjoitettu tiedostoon {filePath}");
        }
    }
}
