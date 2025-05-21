using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_testi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriisi = new int[2, 3];  // 2 riviä, 3 saraketta

            // Arvojen asettaminen
            matriisi[0, 0] = 1;
            matriisi[0, 1] = 2;
            matriisi[0, 2] = 3;
            matriisi[1, 0] = 4;
            matriisi[1, 1] = 5;
            matriisi[1, 2] = 6;

            // Matriisin läpikäyminen
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Matriisi[{i},{j}] = {matriisi[i, j]}");
                }
            }



        }
    }
}
