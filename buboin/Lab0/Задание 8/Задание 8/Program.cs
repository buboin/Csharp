using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max, min;
            Console.WriteLine("Сортировка массива");
            Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];

            i = 0;
            do 
            {
                Console.Write("A[{0}]=", i);
                mass[i] = int.Parse(System.Console.ReadLine());
                i++;
            }
            while(i < n);

            Console.WriteLine("Исходный массив:");

            i = 0;
            do
            {
                Console.Write("  " + mass[i]);
                i++;
            }
            while (i < n);

            i=0;
            max = mass[i];
            do
            {
                if (max < mass[i])
                    max = mass[i];
                i++;
            }
            while (i < n);

            i = 0;
            min = mass[i];
            do
            {
                if (mass[i] < min)
                    min = mass[i];
                i++;
            }
            while (i < n);
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент {0}", max);
            Console.WriteLine("Минимальный элемент {0}", min);

            Console.WriteLine("Их среднее арифметическое {0:F1}", 1.0*(max + min) / 2);
            Console.ReadKey();

        }
    }
}
