using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Tehtävä_7
{
    internal class Program
    {
        static void Main()
        {
            int tulos = fibonacci(10);
            Console.WriteLine(tulos);
        }

        static int fibonacci(int n) 
        { 
            if (n==0) return 0;
            if (n==1) return 1;

            int a = 0, b = 1, summa = 0;

            for (int i = 2; i <= n; i++)
            {
                summa = a + b;
                a = b;
                b = summa;

            }

            return summa;
        }
        
    
    
    }   
}
