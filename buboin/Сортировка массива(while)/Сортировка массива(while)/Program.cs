using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_массива
{
    class Program
    {



        static void Main(string[] args)
        {
            int buf;
            int i = 0;
            int[] mass = { 9, 4, 8, 5 };
            while (i < mass.Length - 1)
            {
                if (mass[i] < mass[i + 1])
                {
                    buf = mass[i];
                    mass[i] = mass[i + 1];
                    mass[i + 1] = buf;
                    i = i + 1;
                }
                else
                {
                    i = 0;
                }
                System.Console.WriteLine("Сортировка массива");

                for (i = 0; i < mass.Length; i++)
                    System.Console.Write("\t A[{0}] = {1}", i, mass[i]);
                System.Console.ReadKey();
            }
        }

    }
}
