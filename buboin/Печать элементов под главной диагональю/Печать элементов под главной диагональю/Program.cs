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

            int[][] mtr = new int[4][];
            Random rnd = new Random();
            for (int i = 0; i < mtr.Length; i++)
            {
                mtr[i] = new int[4];
                for (int j = 0; j < mtr[i].Length; j++)
                {
                    mtr[i][j] = rnd.Next(100);
                    System.Console.Write("{0}    ", mtr[i][j]);

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine();

            for (int i = 0; i < mtr.Length; i++)
            {
                for (int j = 0; j < mtr[i].Length; j++)
                {
                    if (i >= j)
                    {
                        System.Console.Write("{0}    ", mtr[i][j]);
                    }
                }
                System.Console.WriteLine();
            }
          
            System.Console.ReadKey();

        }
    }
}
