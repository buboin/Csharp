using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string number =  "3347112345678909897634432";
          
            string n = "1";
            int i = 0;  
            int x = -1; // Так как метод IndexOf() возвращает "-1" если первое вхождение подстроки не найдено, то приходится использовать вспомагательную, вместо і, что б начать цикл
            int count = -1; 
            while (i != -1)
            {
                i = number.IndexOf(n, x + 1); // получаем индекс первого вхождения  
                x = i; 
                count++;  
            }
            Console.WriteLine("Исходное число" + number);
            Console.WriteLine("Количество вхождений цифры 1 в число  равно " + count);
            Console.ReadKey();
        }

    }
}
