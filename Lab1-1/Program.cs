using System;
using System.Collections.Generic;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] a = { { 0, 5, 2, 0, 0 },
                         { 0, 0, 7, 0, 0 },
                         { 0, 4, 0, 6, 1 },
                         { 0, 3, 0, 0, 9 },
                         { 0, 0, 0, 0, 0 } };

            int maxCount = 0;
            int currentCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != 0)
                    {
                        currentCount++;
                    }
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 0;
            }

            int[,] TA = new int[n, maxCount];
            int[,] TC = new int[n, maxCount];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != 0)
                    {
                        TA[i, currentCount] = a[i, j];
                        TC[i, currentCount] = j + 1;
                        currentCount++;
                    }
                }
                currentCount = 0;
            }

            //Вывод TA и TC
            Console.WriteLine("TA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < maxCount; j++)
                {
                    Console.Write(TA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("TC:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < maxCount; j++)
                {
                    Console.Write(TC[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
