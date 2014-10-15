using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 1 до 9");


            int k;
            for (; Console.ReadKey(true).Key != ConsoleKey.Escape; )
            {
                k = Convert.ToInt16(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("4");
                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                    case 7:
                        Console.WriteLine("7");
                        break;
                    case 8:
                        Console.WriteLine("8");
                        break;
                    case 9:
                        Console.WriteLine("9");
                        break;
                    default:
                        Console.WriteLine("Программа завершена");
                        break;
                }

            }

        


              Console.ReadKey();
        }
    }
}
