using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Tehtävä_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;
            double laskuri = 0;
            double luku1;

            

            do
            {

                 Console.WriteLine("Anna luku: ");
                luku1 = double.Parse(Console.ReadLine());

                if (luku1 >= 0 )
                {
                    summa += luku1;
                    laskuri++;
                }

            }
            while (luku1 >= 0);
            if (laskuri>0)
            {
                double keskiarvo = summa / laskuri;
                Console.WriteLine("Lukujen keskiarvo: "+ keskiarvo);
            }
            else
            {
                Console.WriteLine("Et syöttänyt positiivista lukua");
            }

        }
    }
}
