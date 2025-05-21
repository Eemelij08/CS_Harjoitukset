using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.testi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hei maailma!");


            // Lisää tekstiä loppuun
            sb.Append(" Miten voit?");

            // Lisää tekstiä tiettyyn kohtaan
            sb.Insert(4, "ihana ");


            // Korvaa tekstiä
            sb.Replace("Hei", "Terve");


            Console.WriteLine(sb.ToString());
        }
    }
}
