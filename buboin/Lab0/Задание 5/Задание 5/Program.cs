using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, j;
            Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива");
            int[] mass = new int[n];
            i = 0;
            do
            {
                System.Console.Write("A[{0}]=", i);
                mass[i] = int.Parse(System.Console.ReadLine());
                i++;
            }
            while (i < n);

            mass = SortWithReturn(mass);

            i = 0;
            do
            {
                if (mass[i] == mass[i + 1])
                    Console.WriteLine(" В массиве есть дубликат {0}", mass[i]);
                i++;
            }
            while(i<n-1);

            Console.ReadKey();
        }
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






        
    }
}
