using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä pistemäärä: ");
            bool validInput = int.TryParse(Console.ReadLine(),out int luku1);


            if (luku1>100)
            {
                Console.WriteLine("100/100");
                
            }else if (luku1 >50)
            {
                Console.WriteLine("50/100");
            }else
            {
                Console.WriteLine("0/100");
            }//en ole varma teinkö tämn tehtävän oikein...
        }
    }
}
