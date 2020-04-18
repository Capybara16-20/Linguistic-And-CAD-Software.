using System;

namespace Lab5_1
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
                int low = 0;
                int high = keys.GetLength(0) - 1;
                result = BinaryRecursiveSearch(keys, key, low, high);
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

        public static int BinaryRecursiveSearch(int[,] keys, int key, int low, int high)
        {
            while (high >= low)
            {
                int p = (low + high) / 2;
                if (keys[p, 0] == key)
                {
                    return keys[p, 1];
                }
                else if(keys[p, 0] > key)
                {
                    return BinaryRecursiveSearch(keys, key, low, p - 1);
                }
                else
                {
                    return BinaryRecursiveSearch(keys, key, p + 1, high);
                }
            }
            return 0;
        }
    }
}
