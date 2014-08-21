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

            //for(<операция, выполняемая до начала работы цикла>;<условие>;<то, что выполняется после тела цикла>)
            //{
            //тело цикла
            //}
            int m = 0,n=9, k=0;
            for (m = 8; n < 10; k=8)
            {
                mtr[0] = new int[10];
            }

            //while(условие){
            //тело цикла
            //}
            // пока выполняется условие, будет выполняться тело цикла
            //while (true)
            //{

            //}

            //do
            //{
            // тело цикла
            //}
            //while (true);
            //do
            //{

            //}
            //while (true);

            for (int i = 0; i < mtr.Length; i++)
            {
                mtr[i] = new int[5];
                for (int j = 0; j < mtr[i].Length; j++)
                {
                    mtr[i][j] = rnd.Next();
                        
                }
            }

            for (int j = 0; j < mtr[0].Length; j++)
            {
                for (int i = 0; i < mtr.Length; i++)
                {
                    System.Console.Write("{0}\t", mtr[i][j]);
                }
                System.Console.WriteLine();
            }

            if (m>1)
            {

            }
            else
            {
                if (n > 1) { }
            }

            n = 1;
            switch (n)
            {
                case 1:
                    System.Console.WriteLine("12");
                    break;
                case 2:
                    System.Console.WriteLine("22");
                    break;
                default:
                    System.Console.WriteLine("32");
                    break;
            }

            m = (n > 1) ? 12 : 13;
            if (n > 1)
            {
                m = 12;
            }
            else
            {
                m = 13;
            }

            System.Console.ReadKey();
            // AT: a[j, i]
        }
    }
}
