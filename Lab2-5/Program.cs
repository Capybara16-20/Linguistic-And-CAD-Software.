using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 5, 4, 3, 2, 7, 6, 1, 9 };
            int[] I = new int[] { 1, 3, 4, 1, 2, 3, 3, 4 };
            int[] JC = new int[] { 0, 0, 3, 5, 6, 8 };
            int n = 5;
            int[,] a = new int[n, n];
            int col = 0;
            for (int i = 1; i < JC.Length; i++)
            {
                for (int j = JC[i - 1]; j < JC[i]; j++)
                {
                    a[I[j] - 1, col] = AL[j];
                }
                col++;
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
