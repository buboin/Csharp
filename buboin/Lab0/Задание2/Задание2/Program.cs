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
            int i = 1;
            do 
            {
                if (Simple(i))// обращение к методу проверки на простоту
                {
                    Console.Write(", " +i.ToString());
                }
                i++;    
            }
            while (i <= N);
            Console.ReadKey();

        }



        public static bool Simple(int N)// N равно текущему значению i
        {
            int j = 2;
            do
            {
                if (N % j == 0)// ищем числа, на которые может поделиться наше число без остатка
                {
                    return false; 
                }
                j++;
            }
            while (j <= N - 1);
            
            return true;
           
        }

    }
}
 