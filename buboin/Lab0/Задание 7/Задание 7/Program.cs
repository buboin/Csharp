using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
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
            i=0;
            while ( i < n)
            {
                System.Console.Write("A[{0}]=", i);
                mass[i] = int.Parse(System.Console.ReadLine());
                i++;
            }
            i = 0;
            while (i < n ) 
            {
                if (mass[i] % 10 == 0)
                {
                    Console.WriteLine("Круглый элемент {0} с индексом {1} ", mass[i] , i);
                }
                i++;
            }






            Console.ReadKey();
        }
    }
}
