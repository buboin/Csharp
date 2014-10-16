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


            ConsoleKey k;

            for (; ; )
            {
                k = Console.ReadKey().Key;
                Console.Clear();
                Console.WriteLine("Введите число от 1 до 9");
                switch (k)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\n1");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\n2");
                        break;
                    case  ConsoleKey.D3:
                        Console.WriteLine("\n3");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\n4");
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\n5");
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("\n6");
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("\n7");
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine("\n8");
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine("\n9");
                        break;
                    case ConsoleKey.Escape:
                        return;
                    
                }

            }

        


              Console.ReadKey();
        }
    }
}
