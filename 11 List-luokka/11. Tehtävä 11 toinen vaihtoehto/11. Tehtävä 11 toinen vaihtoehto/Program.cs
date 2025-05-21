using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_11_toinen_vaihtoehto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tosi = false;

            List<string> kauppa = new List<string>();

            do
            {

                Console.WriteLine("~Kauppa lista~");
                Console.WriteLine("1. Lisää tuote");
                Console.WriteLine("2. poista tuote");
                Console.WriteLine("3. Näytä valmis lista");
                Console.WriteLine("4. Poistu");

                Console.Write("Syötä numero: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Syötä mitä haluat lisätä listaan: ");
                        string lisaa = Console.ReadLine();
                        kauppa.Add(lisaa);
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        Console.WriteLine("Syötä mitä haluat poistaa: ");
                        string poista = Console.ReadLine();
                        kauppa.Remove(poista);
                        Console.WriteLine(" ");
                        break;

                    case 3:
                        Console.WriteLine(" ");
                        Console.WriteLine("Tässä valmis lista: ");
                        Console.WriteLine(kauppa);

                        break;

                    case 4:

                        tosi = true;
                        break;

                    default:
                        Console.WriteLine("Virheellinen syöte!");
                        break;


                }

            } while (!tosi);

            foreach (string s in kauppa)
            {

                Console.WriteLine(s);
            }
        }
    }
    
}
