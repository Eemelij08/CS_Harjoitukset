using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Tehtävä_1_neljäs_vika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents"; //string filePath = "C:\\Users\\Public\\Documents";
            string quote = @"Tämä on ""sanamerkkijono"".";
            Console.WriteLine(filePath);
            Console.WriteLine(quote);
        }
    }
}
