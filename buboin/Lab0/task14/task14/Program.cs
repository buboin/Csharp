using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[18] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 };
            Console.WriteLine("Введите количество чисел Фибоначчи для вычисления(не больше 18)");
            int k = Convert.ToInt16(Console.ReadLine());
            int i ;
            Console.WriteLine("Числа Фибоначчи");
            for ( i = 1; i <= k; i++)
            {
                mass[i + 1] = mass[i] + mass[i - 1];
                Console.Write("\t" + mass[i + 1]);
            }
            
            Console.ReadKey();
        }
    }
}
