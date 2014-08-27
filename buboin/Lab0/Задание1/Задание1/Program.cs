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
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + mass[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Введите число, на которое будет произведен сдвиг");
            int k = Convert.ToInt16(Console.ReadLine()); // Преобразует строковое представление числа в 16-битовое целое число



            if (k >= 0)
            {

                for (int i = 0; i < k; i++)// внешний цикл, запускает внутренний k раз
                {
                    int massLast = mass[n - 1];  // понадобится для сохранения последнего элемента
                    for (int j = n - 1; j > 0; j--)// внутренний цикл, сдвигает элементы массива на 1 позицию, последний элемент не трогается
                    {
                        mass[j] = mass[j - 1];// сдвиг
                    }
                    mass[0] = massLast;// ставим последний элемент на место 1-ого
                }
            }

            else
            {

                for (int i = 0; i > k; i--)
                {
                    int massFirst = mass[0];  
                    for ( int j = 1; j <=n-1; j++)
                    {
                        mass[j-1] = mass[j];
                    }
                    mass[n-1] = massFirst; 
                }

            }



            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write("\t" + mass[i]);
            }
            Console.ReadKey();



        }
    }
}
