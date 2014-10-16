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
            for ( i = 0; i < mtr.Length; i++)
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





            for ( i = 0; i < mtr[0].Length; i++) // печать элементов под главной диагональю
            {
                for (int j = 0; j < mtr.Length; j++)
                {
                    if (i >= j)
                    {
                       Console.Write("{0}    ", mtr[i][j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            
            for (i = 0; i < mtr[0].Length; i++) // печать элементов под побочной диагональю
            {
                int j = mtr.Length;
                while (j > 0)
                {
                   

                    Console.Write("{0}    ", mtr[i][j]);


                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}