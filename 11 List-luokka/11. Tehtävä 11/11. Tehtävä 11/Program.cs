using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tammone = false;
            
            Console.WriteLine("~Kauppa lista~");
            Console.WriteLine("1. Lisää tuote");
            Console.WriteLine("2. poista tuote");
            Console.WriteLine("3. Näytä valmis lista");


            Console.Write("Syötä numero: ");
            int choice = int.Parse(Console.ReadLine());


            List<string> kauppa = new List<string>();

            do
            {
                foreach (string k in kauppa)
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Syötä mitä haluat lisätä: ");
                            Console.WriteLine(k);
                                string lisaa = Console.ReadLine();
                            kauppa.Add(lisaa);
                            break;
                        
                        case 2:
                        
                            Console.WriteLine("Syötä mitä haluat poistaa: ");
                            string poista = Console.ReadLine();
                            kauppa.Remove(poista);
                            break;
                        
                        case 3:

                            Console.WriteLine(kauppa);
                            tammone = true;
                            break;

                        default:
                            Console.WriteLine("Teit virheellisen valinnan.");
                            break;
                    }
            } while (!tammone);
        }
    }
}
