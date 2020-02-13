using System;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 0, 0, 4, 3, 9, 0, 6, 1, 0, 2, 8, 0, 4, 0 };
            int[] I = new int[] { 1, 2, 2, 3, 5, 3, 1, 3, 4, 2, 3, 5, 3, 0 };
            int n = 5;
            int[,] a = new int[n, n];
            int col = 0;
            int row = 0;
            for (int i = 0; i < I.Length; i++)
            {
                if (AL[i] == 0)
                {
                    col = I[i] - 1;
                }
                else
                {
                    row = I[i] - 1;
                    a[row, col] = AL[i];
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
