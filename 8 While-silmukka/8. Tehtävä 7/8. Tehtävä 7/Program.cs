using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Tehtävä_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vuosi = 0;
            
            Console.WriteLine("Anna alkusäästö: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double säästö);

            Console.WriteLine("Kerro tavoitesumma: ");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double tavoite);

            Console.WriteLine("Kerro vielä korkoprosentti (%) : ");
            bool validInput3 = double.TryParse(Console.ReadLine(), out double korko);

            while(säästö<=tavoite && validInput1 && validInput2 && validInput3)
            {
                säästö = säästö *(1+ korko / 100);
                Console.WriteLine("vuosi:"+vuosi+ " ja säästö: "+säästö);
                vuosi++;
                
                
               
            }
        }
    }
}
