using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rluku = new Random() ;
            List<int> lista = new List<int>();
            for (int i = 1; i<=10;i++)
                
            {
               
                lista.Add(rluku.Next(10,21));    
            }
            Console.WriteLine("Anna luku jota etsitään: ");
            int kluku = int.Parse(Console.ReadLine());

            int kertaa = lista.Count(x => x == kluku);
            Console.WriteLine("Luku " + kluku+ " esiintyy "+kertaa+" kertaa");




        }
    }
}
