using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            int ReadInt(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            int Akkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m > 0 & n == 0) return Akkerman(m - 1, 1);
                else
                {
                    return Akkerman(m - 1, Akkerman(m, n - 1));
                } 
                
            }

            int m1 = ReadInt("Введите m: ");
            int n2 = ReadInt("Введите n: ");

            if(m1<0 | n2 < 0)
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            else
            Console.WriteLine(Akkerman(m1, n2));

        }
    }
}
