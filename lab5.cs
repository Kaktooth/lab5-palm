using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину массиву");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int prod = 1;
            int c= LastNum(a);
            int min=0;
            Console.WriteLine("Введіть числа массиву");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                c = LastNum(a);
                if (a[i] == c)
                {
                    min = a.Length - i;
                }
            }
           for (int i=0; i<min;i++)
            {
                prod *= a[i];
            }
         
            Console.WriteLine(LastNum(a));
            Console.WriteLine("prod: {0}",prod);
            Console.ReadLine();
        }
        static int LastNum(int[] array)  //Функція пошуку останього відємного числа
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0) return array[i];
            }
            return 0; //Якщо відємного числа немає виводить 0
        }
    }
}