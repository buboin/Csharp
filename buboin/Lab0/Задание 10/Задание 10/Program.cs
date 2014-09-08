using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            const int n = 5;
            int[] mass = new int[n] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив");
            while (i < n)
            {
                Console.WriteLine("A[{0}] = {1}", i, mass[i]);
                i++;
            }

            Console.WriteLine("ВВедите индекс элемента, которой не будет печататься");

            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Новый массив");
            i = 0;
            switch (1)
            {
                case 1:
                    if (i == k)
                    {
                        i++;
                        goto case 2;
                    }
                    else
                        
                        goto case 2;
                case 2:
                    if (i < n)
                    {
                        Console.Write(mass[i]);
                        i++;
                        goto case 1;
                    }
                    else break;
                    
            }
            Console.ReadKey();
        }

    }

}