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
            String[] mass = new string[5] {"33471","764","3467","123","98765"};
            
            Console.WriteLine( "Исходный массив");
            string s2 = mass[i];

            for ( i = 0; i < mass.GetLength(0); i++)
                   Console.Write(mass[i]+" ");

            Console.WriteLine();
            Console.WriteLine("Числа, не содержащие 1");


            string a = "1";


            int o = 0;
            for (i = 0; i < mass.GetLength(0); i++)
                if (mass[i].Contains(a))
                     o =1234567;
                else
                    Console.Write(mass[i] + "   ");
      

          Console.ReadKey();  
        }
      
    }
}
