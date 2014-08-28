using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int n = 5;
            int[] mass = new int[n] { 3, 4, 5, 6, 7 };
            Console.WriteLine("Исходный массив: ");
            int i = 0;
            while (i < n)
            {
                Console.Write("\t" + mass[i]);
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("Введите число, на которое будет произведен сдвиг");
            int k = Convert.ToInt16(Console.ReadLine()); // Преобразует строковое представление числа в 16-битовое целое число



            if (k >= 0)
            {
                i = 0;
                while ( i < k)// внешний цикл, запускает внутренний k раз
                {
                    int massLast = mass[n - 1];  // понадобится для сохранения последнего элемента
                    int j = n - 1;
                    while ( j > 0)// внутренний цикл, сдвигает элементы массива на 1 позицию, последний элемент не трогается
                    {
                        mass[j] = mass[j - 1];
                        j--;
                    }

                    mass[0] = massLast;// ставим последний элемент на место 1-ого
                    i++;
                }
            }

            else
            {
                i = 0;
                while (  i > k)
                {
                    int massFirst = mass[0]; 
                    int j = 1;
                    while (  j <=n-1)
                    {
                        mass[j-1] = mass[j];
                        j++;
                    }
                    mass[n-1] = massFirst;
                    i--;
                }

            }



            Console.WriteLine("Новый массив: ");
            for ( i = 0; i < n; ++i)
            {
                Console.Write("\t" + mass[i]);
            }
            Console.ReadKey();



        }
    }
}
