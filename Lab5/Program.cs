using System;
using System.Collections.Generic;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] keys = new int[,] { { 12, 1000 }, { 3, 3000 }, { 8, 4000 }, { 1, 7000 }, { 6, 5000 },
                                       { 4, 90000 }, { 9, 2000 }, { 11, 800 }, { 7, 1300 }, { 5, 9999 } };
            int result = 0;

            Console.Write("Введите значение ключа искомой записи: ");
            if (int.TryParse(Console.ReadLine(), out int key))
            {
                result = LinearSearch(keys, key);
                if (result == 0)
                {
                    Console.WriteLine("Запись не найдена");
                }
                else
                {
                    Console.WriteLine("Искомая запись: {0}", result);
                }
            }
            else
            {
                Console.WriteLine("Введён некорректный ключ!");
            }
        }

        public static int LinearSearch(int[,] keys, int key)
        {
            for (int i = 0; i < keys.GetLength(0); i++)
            {
                if (keys[i, 0] == key)
                {
                    return keys[i, 1];
                }
            }
            return 0;
        }
    }
}
