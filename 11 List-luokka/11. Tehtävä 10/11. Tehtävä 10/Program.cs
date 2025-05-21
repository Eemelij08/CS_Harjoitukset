using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tehtävä_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaa = new List<int>() { 1,2,3,4,5,6,7,7,8,8,};
            List<int> listab = new List<int>() { 4, 3, 2, 1, 9, 10, 8, 7, 6, 5 };

            List<int> yhdistetty = listaa.Union(listab).ToList();

            foreach (int i in yhdistetty)
            {
                Console.WriteLine(i);
  
            }
        
            foreach(int i in listaa)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
            
            foreach(int i in listab)
            {
                Console.Write(i);
                
            }
            Console.WriteLine(" ");
            Console.WriteLine(" Kaksi alinta listaa ovat alkuperäiset listat, ylin lista on uusin lista. Tämä osoittaa että ylin lista ei ole pelkkä kopio alimmaisista listoista.");
        }
    }
}
