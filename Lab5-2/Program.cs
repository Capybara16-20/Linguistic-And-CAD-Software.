using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] keys = new int[,] { { 12, 1000 }, { 3, 3000 }, { 8, 4000 }, { 1, 7000 }, { 6, 5000 },
                                       { 4, 90000 }, { 9, 2000 }, { 11, 800 }, { 7, 1300 }, { 5, 9999 } };*/
            int[,] keys = new int[,] { { 1, 7000 }, { 3, 3000 }, { 4, 90000 }, { 5, 9999 }, { 6, 5000 },
                                       { 7, 1300 }, { 8, 4000 }, { 9, 2000 }, { 11,800 }, { 12, 1000 } };
            int result = 0;

            Console.Write("Введите значение ключа искомой записи: ");
            if (int.TryParse(Console.ReadLine(), out int key))
            {
                result = BinaryIterativeSearch(keys, key);
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

        public static int BinaryIterativeSearch(int[,] keys, int key)
        {
            int low = 0;
            int high = keys.GetLength(0) - 1;
            while(low <= high)
            {
                int p = (low + high) / 2;
                if (keys[p, 0] == key)
                {
                    return keys[p, 1];
                }
                else if (keys[p, 0] > key)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return 0;
        }
    }
}
