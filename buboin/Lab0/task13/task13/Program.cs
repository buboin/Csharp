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

           
            int i=0;
            String[] mass = new string[5] {"33471","764","3467пр","123","98765"};
            
            Console.WriteLine( "Исходный массив");
            string s2 = mass[i];
            i=0;
            do
            {
                Console.Write(mass[i] + " ");
                i++;
            }
            while (i < mass.GetLength(0));
            Console.WriteLine();
            Console.WriteLine("Числа, не содержащие 1");
            
            i=0;
            do
            {
                if (mass[i].Contains("1"))
                    i++;
                else
                {
                    Console.Write(mass[i] + "   ");
                    i++;
                }
            }
            while(i < mass.GetLength(0));

          Console.ReadKey();  
        }
      
    }
}
