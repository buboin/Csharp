using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите массив");
            Console.WriteLine();
            string mass = Console.ReadLine();
            string[] str = mass.Split(' ');

            for (int i = 0; i < str.Length; i++)  //проверка массива на выполнение условия
            {
                Console.Write(str[i]);
                string st = str[i];
                if (st[0] == st[st.Length - 1])
                {
                    Console.Write("  Массив является палиндромом");
                }
                else
                {
                    Console.Write("  Массив не является палиндромом");
                }

            }
            Console.ReadKey();
        }
    }
}
