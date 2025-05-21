using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tehtävä_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double ALV = 25.5;




            Console.Write("Anna tuotteen hinta verottomana: ");
            string input = Console.ReadLine();


            bool validInput = double.TryParse(input, out double veroton);

            if (validInput)
            {

                double koko = veroton * (ALV/100) + veroton;

                Console.WriteLine($"Tuotteen kokonaishinta on: {koko}");
            }
            else
            {

                Console.WriteLine("Virheellinen syöte. Anna kelvollinen luku.");
            }

        }
    }
}
