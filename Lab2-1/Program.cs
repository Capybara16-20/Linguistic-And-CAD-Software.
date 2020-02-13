using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] TA = { { 2, 3, 0 },
                          { 3, 0, 0 },
                          { 2, 4, 5 },
                          { 2, 5, 0 },
                          { 0, 0, 0 }};
            int[,] TC = { { 5, 2, 0 },
                          { 7, 0, 0 },
                          { 4, 6, 1 },
                          { 3, 9, 0 },
                          { 0, 0, 0 }};
            int n = 5;
            int[,] a = new int[n, n];
            for (int i = 0; i < TA.GetLength(0); i++)
            {
                for (int j = 0; j < TC.GetLength(1); j++)
                {
                    if (TC[i, j] != 0)
                    {
                        a[i, TA[i, j] - 1] = TC[i, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
