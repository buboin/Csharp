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
            string[] mass = new string[n];
            i = 0;
            while (i < n)
            {
                System.Console.Write("A[{0}]=", i);
                mass[i] = string.Format(System.Console.ReadLine());
                i++;
            }
            i = 0;
            while (i < n)
            {
                int val;
                try
                {
                    val = int.Parse(mass[i]);
                    if (val % 10 == 0)
                    {
                        Console.WriteLine("Круглый элемент {0} с индексом {1} ", mass[i], i);
                    }
                }
                catch (Exception e)
                {

                }

                
                i++;
            }






            Console.ReadKey();
        }
    }
}
