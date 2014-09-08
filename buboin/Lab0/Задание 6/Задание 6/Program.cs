using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
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
                mass[i] = int.Parse(System.Console.ReadLine());
            }


            int k = 1;
            switch (k) 
            { 
                case 1:

            Console.WriteLine(" \n Текущий массив:");
            for (i=0; i<n; i++)
                Console.Write(" " + mass[i]);
            goto case 2;
                case 2:
            for (i = 0; i < n; i++)
            {
                if (mass[i] == 0)
                    goto default;
            }
            goto case 3;
                case 3:
            for( i=0; i<n;i++)
            {
                mass[i] = mass[i] - 1;
            }
                    goto case 1;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Появился элемент, равный 0");
                    break;

            }

            Console.ReadKey();
        }
    }
}
