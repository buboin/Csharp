using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_массива
{
    class Program
    {
        static void Sort(int[] mass)
        {
            int buf;
            for (bool f = true; f; )
            {
                f = false;
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    if (mass[i] < mass[i + 1])
                    {
                        buf = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = buf;
                        f = true;
                    }
                }
            }
        }

        static int[] SortWithReturn(int[] mass)
        {
            int buf;
            for (bool f = true; f; )
            {
                f = false;
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    if (mass[i] < mass[i + 1])
                    {
                        buf = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = buf;
                        f = true;
                    }
                }
            }

            return mass;
        }

        static void Main(string[] args)
        {
            int n, i;
            System.Console.WriteLine("Сортировка массива");
            System.Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
            {
                System.Console.Write("A[{0}]=", i);
                mass[i] = int.Parse(System.Console.ReadLine());// ввод значений массива вручную
            }

            int[] mass1 = { 1, 2, 78, 5 };

            Sort(mass);
            mass1 = SortWithReturn(mass1);

            //// цикл for для сортировки по возрастанию
            //for (int k = n - 1; k > 0; k--)
            //    for ( i = 0; i < k; i++)
            //        if (mass[i] > mass[i + 1])
            //        {
            //            buf = mass[i];
            //            mass[i] = mass[i + 1];
            //            mass[i + 1] = buf;
            //        }
            for ( i = 0; i < n; i++)
                System.Console.Write("\t A[{0}] = {1}", i, mass[i]);


            // цикл do while
            



            System.Console.ReadKey();
        }
    }
}
