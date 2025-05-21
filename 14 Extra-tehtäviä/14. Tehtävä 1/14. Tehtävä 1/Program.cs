using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _14.Tehtävä_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Random noppa1 = new Random();
            Thread.Sleep(2000);
            Random noppa2 = new Random();

            int luku1 = noppa1.Next(6) +1;
            int luku2 = noppa2.Next(6) +1;

            
            
            Console.WriteLine(luku1);
            Console.WriteLine(luku2);
            if (luku1 == 1 && luku2 == 1)
            {
                Console.WriteLine("snake eyes");
            
            }

            else if (luku1 == luku2)
            {
                Console.WriteLine("Luvut ovat samat");

            }
            else
            {
                Console.WriteLine("Luvut ovat erit");
            }
        }
    }
}
