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



            bool flag = false;
            for (; !flag ;)
            {

                Console.WriteLine(" \n Текущий массив:");
                for (i = 0; i < n; i++)
                {
                    Console.Write(" " + mass[i]);
                    
                }


                for (i = 0; i < n; i++)
                {
                    if (mass[i] == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Появился элемент, равный 0");
                        flag = true;
                        
                    }
                }

                for (i = 0; i < n; i++)
                {
                    mass[i] = mass[i] - 1;
                }
                
            }

            Console.ReadKey();
        }
    }
}
