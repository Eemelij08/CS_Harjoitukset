using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Tehtävä_1_toinen_osa
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            


            string name = "Eemeli";
            int age = 16;


            string message = $"Nimeni on {name} ja olen {age} vuotta vanha.";
            Console.WriteLine(message);

            string text = "Tykkään omenoista";
            string newText = text.Replace("omenoista", "päärynöistä!");
            Console.WriteLine(newText);  // "Tykkään päärynöistä!"


        }
    }
}
