using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2

{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число, до которого нужно найти простые числа");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)// цикл от 1 до заданного N
            {
                if (Simple(i))// обращение к методу проверки на простоту
                {
                    Console.Write(", " +i.ToString());
                }
            }
            Console.ReadKey();

        }



        public static bool Simple(int N)// N равно текущему значению i
        {
            for (int j = 2; j <= N-1; j++)
            {
                if (N % j == 0)// ищем числа, на которые может поделиться наше число без остатка
                {
                    return false; // нашлось, не печатаем
                }
            }
            return true;// не нашлось, печатаем
        }

    }
}
 