using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрица
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[][] mtr = new int[4][];
            Random rnd = new Random();
            for (i = 0; i < mtr.Length; i++)
            {
                mtr[i] = new int[mtr.Length];
                for (int j = 0; j < mtr[i].Length; j++)
                {
                    mtr[i][j] = rnd.Next(100);
                    Console.Write("{0}    ", mtr[i][j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();






            int k, a, b;
            i = 0;
            
            

            int[][] mass = new int[mtr.Length][];
            for (i = 0; i < mtr.Length; i++)
            {
                b = 0;
                mass[i] = new int[mtr.Length-1];
                k = rnd.Next(mtr.Length-1);
                for (int j = 0; j < mtr[i].Length;j++ )
                {
                    if (j == k)
                    {
                        continue;
                    }
                    else
                    {
                        mass[i][b]=mtr[i][j];
                        Console.Write(mass[i][b] + "  ");
                        
                        b++;
                        continue;
                    }
                   
                    j++;
                }
                Console.WriteLine();

            }

            


            Console.ReadKey();

        }
    }
}