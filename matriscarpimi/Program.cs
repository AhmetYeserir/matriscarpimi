using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriscarpimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = { { 1, 1, 5, 3 }, { 4, 1, 6, 7 }, { 2, 9, 10, 3 } };

            int[,] m2 = { { 2, 1, 2 }, { 3, 6, 2 }, { 6, 7, 8 }, { 9, 3, 7 } };

            int[,] sonuc = new int[4, 4];

            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)

                        sonuc[k, i] += m2[k, j] * m1[j, i];
                }
            } 
            for (int i = 0; i < 4; i++)

            {
                Console.WriteLine();

                for (int j = 0; j < 4; j++)

                    Console.Write("{0}\t", sonuc[i, j]);
           }
            Console.ReadKey();
        }
    }
}
