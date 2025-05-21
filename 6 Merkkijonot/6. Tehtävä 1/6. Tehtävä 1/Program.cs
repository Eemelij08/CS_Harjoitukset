using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tervehdys = "Hei, Maailma!";
            Console.WriteLine(tervehdys);


            string etunimi = "Eemeli";
            string sukunimi = "Jalonen";
            string kokonimi = etunimi + " " + sukunimi;
            Console.WriteLine(kokonimi);

            string text = "TESTI TEKSTI JOTA MUOKKASIN HIEMAN";

            Console.WriteLine(text.Length);
            string part = text.Substring(7, 5);
            Console.WriteLine(part);


        }
    }
}
