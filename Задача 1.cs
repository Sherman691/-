using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

            int ReadInt(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }


            void PrintNumbers(int botRange, int topRange)
            {
                if (botRange > topRange) return;
                Console.WriteLine(botRange + " ");
                PrintNumbers(botRange+1, topRange);
            }



            int M = ReadInt("Введите нижнюю границу: ");
            int N = ReadInt("Введите верхнюю границу: ");

            if (M >= N)
            {
                Console.WriteLine("Число верхенй границы должно быть больше нижней");
            }
            else
            PrintNumbers(M, N);
        }
    }
}
