using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näet juuston maassa, mitä teet?");
            Console.WriteLine("1. Syö juusto!");
            Console.WriteLine("2. Älä koske juustoon!");
            Console.WriteLine("3. Poistu paikalta");


            Console.Write("Syötä valintasi: ");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Syöt juuston ja huomaat että se maistui hyvälle, mutta jäit kiinni hiiren loukkuun.");
                    break;
                case 2:
                    Console.WriteLine("Kierrät juuston kaukaa ja huomaat, että juusto olikin kiinni hiirenloukussa.");
                    break;
                case 3:
                    Console.WriteLine("Käännyt 360° etkä tarkastele juustoa sen tarkemmin.");
                    break;
                default:
                    Console.WriteLine("Teit virheellisen valinnan.");
                    break;
            }
        }
    }
}
