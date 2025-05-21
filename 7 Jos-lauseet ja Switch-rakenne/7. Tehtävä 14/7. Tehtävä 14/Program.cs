using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Tehtävä_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna piste x kokonaislukuna: ");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double x);

            Console.WriteLine("Anna piste y kokonaislukuna: ");
            bool validInput2 = double.TryParse(Console.ReadLine(),out double y);

            if (validInput1 && validInput2)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Piste on ensimmäisessä neljänneksessä eli oikealla yläkulmassa.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Piste on toisessa neljänneksessä eli vasemmalla yläkulmassa.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Piste on kolmannessa neljänneksessä eli vasemmalla ala kulmassa");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Piste on neljännessä neljänneksellä eli oikealla ala kulmassa");
                }
            
                else if (x>0 ||x<0 && y==0)
                {
                    Console.WriteLine("Piste on x akselilla");
                }
                
                else if (x==0 && y>0 || y<0)
                {
                    Console.WriteLine("Piste on y akselilla");
                }  
           
                else if (x==0 && y ==0)
                {
                Console.WriteLine("Piste on origossa");
                }    
            
            
            }   
            else
            {
                Console.WriteLine("Anna kelvollinen luku");
            }
        }
    }
}
