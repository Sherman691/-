using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

            int ReadInt(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            int[] GenerateArray(int size)
            {
                int[] array = new int[size];
                Random rand = new Random();

                for (int i = 0; i < size; i++)
                    array[i] = rand.Next(0, 11);
                return array;
               
            }

            void flipArray(int[] array, int size)
            {
                if (size < 1) return;
                Console.Write(array[size-1] + " ");                
                flipArray(array, size - 1);

            }

            void PrintArray(int[] array)
            {                
                Console.Write($"[{String.Join(", ", array)}]");
            }

            //---------------------------------------

            int sizeArray = ReadInt("Введите размер массива: ");

            int[] newArray = GenerateArray(sizeArray);
            PrintArray(newArray);
            Console.WriteLine();                     

            flipArray(newArray, sizeArray);
            Console.WriteLine();


        }
    }
}
