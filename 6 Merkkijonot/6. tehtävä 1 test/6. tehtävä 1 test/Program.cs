using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.tehtävä_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            

            StringBuilder sb = new StringBuilder("Testi poistetaan");
            sb.Remove(6, 10); // Poistaa "maailma!" (alkaa indeksistä 6, 7 merkkiä)

            Console.WriteLine(sb.ToString());

            
            
        }
    }
}
