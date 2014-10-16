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
                mtr[i] = new int[4];
                for (int j = 0; j < mtr[i].Length; j++)
                {
                    mtr[i][j] = rnd.Next(100);
                    Console.Write("{0}    ", mtr[i][j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();






            int k;
            i = 0;

            for (i = 0; i < mtr.Length; i++)
            {
                k = rnd.Next(4);
                for (int j = 0; j < mtr[i].Length;j++ )
                {


                    if (j == k)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(mtr[i][j] + "  ");
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