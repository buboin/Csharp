using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_массива
{
    class Program
    {



        static int[] SortWithReturn(int[] mass)
        {
            int buf;
            bool f = true;
            do
            {
                f = false;
                int i = 0;
                while (i < mass.Length - 1)
                {

                    if (mass[i] < mass[i + 1])
                    {
                        buf = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = buf;
                        f = true;
                    }
                    i++;
                }
            }
            while (f);

            return mass;
        }




        static void Main(string[] args)
        {
            int n, i;
            System.Console.WriteLine("Сортировка массива");
            System.Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            i = 0;
            do
            {
                System.Console.Write("A[{0}]=", i);
                mass[i] = int.Parse(System.Console.ReadLine());// ввод значений массива вручную
                i++;
            }
            while (i < n);
            mass = SortWithReturn(mass);
            i = 0;
            do
            {
                System.Console.Write("\t A[{0}] = {1}", i, mass[i]);
                i++;
            }
            while (i < n);
            Console.ReadKey();
        }

    }
}
