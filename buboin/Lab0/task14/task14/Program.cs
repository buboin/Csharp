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
            int next, current, previous; 
            Console.WriteLine("Введите количество чисел Фибоначчи для вычисления(не больше 18)");
            int k = Convert.ToInt16(Console.ReadLine());
            int i ;
            Console.WriteLine("Числа Фибоначчи");
            current = 1;
            previous = 0;
            for ( i = 0; i <= k; i++)
            {



                next = current + previous;
                Console.Write("\t"  + next);
                previous = current;
                current = next;
                



            }
            
            Console.ReadKey();
        }
    }
}
