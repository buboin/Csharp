using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] mass1 = new int[n] { 3, 4, 5, 6, 7 };
            int[] mass2 = new int[n] { 7, 5, 6, 3, 4 };
            Console.WriteLine(" Первый исходный массив: ");
            int i = 0;
            while (i < n)
            {
                Console.Write("\t" + mass1[i]);
                i++;
            }
            Console.WriteLine();

            Console.WriteLine(" Второй исходный массив: ");
            int j = 0;
            while (j < n)
            {
                Console.Write("\t" + mass2[j]);
                j++;
            }
            Console.WriteLine();

             mass1 = SortWithReturn(mass1);
             mass2 = SortWithReturn(mass2);

             i = 0;
             j = 0;
             while (i < n)
             {
                 int k = 2;
                 switch(k)
                 {
                     case 1 :
                         if (i == n)
                             Console.WriteLine("Массивы  являются перестановкой элементов друг друга");
                         else
                             goto case 2;
                         break;

                     case 2:
                         if (mass1[i] == mass2[j])
                         {
                             j++;
                             i++;
                             goto case 1;
                         }
                         else goto default;
                     default:
                         Console.WriteLine("Массивы не являются перестановкой элементов друг друга");
                         break;
                 }
                 break;
                                           
             }
            Console.ReadKey();
        }



            static int[] SortWithReturn(int[] mass)
            {
            int buf;
            bool f = true;
            while(f)
            {
                f = false;
                int i =0;
                while ( i < mass.Length - 1 )
                {
                    
                    if (mass[i] < mass[i + 1])
                    {
                        buf = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = buf;
                        f = true;
                    }
                    i++;
                }
            }

            return mass;
           }

        }
    }

