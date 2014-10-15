using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] mtr = new int[5][];
            Random rnd = new Random();
            int i = 0;
            while ( i < mtr.Length)
            {
                mtr[i] = new int[4];
                int j = 0;
                while ( j < mtr[i].Length )
                {
                    mtr[i][j] = rnd.Next(100);
                    System.Console.Write("{0}    ", mtr[i][j]);
                    j++;

                }
                System.Console.WriteLine();
                i++;
            }




               int[][] Mass = new int[mtr.Length][mtr[i].Length-1];




            Console.ReadKey();

        }
    }
}
