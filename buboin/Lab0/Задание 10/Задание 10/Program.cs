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

            Console.WriteLine("Введите индекс элемента, которой не будет печататься");

            int k = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Новый массив");
            i = 0;
            while (i < n)
            {

                if (i != k)
                
                    Console.Write(mass[i]);


                i++;
                
                    
                    

                

            }
            Console.ReadKey();
        }

    }

}