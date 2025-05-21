using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kuukauden numero: ");
            int kuukausi =int.Parse(Console.ReadLine());

            switch (kuukausi)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Talvikuukausi");
                    break;
                    case 3:
                    case 4:
                    case 5:
                    Console.WriteLine("Kevätkuukausi");
                    break;
                    case 6:
                    case 7:
                    case 8:
                    Console.WriteLine("Kesäkuukausi");
                    break;
                case 9:
                    case 10:
                    case 11:
                    Console.WriteLine("Syksykuukausi");
                    break;
                default:
                    Console.WriteLine("Anna kelvollinen kuukauden numero!");
                    break;
   
            }
        }
    }
}
