using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Eemeli_Jalonen
{
    internal class Program
    {
        static int Pos(int numero)
        {
            return Math.Abs(numero);
        }
        
        static void Main()
        {
            Console.WriteLine(Pos(-4));
        }
    
    }
}
