using System;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 0, 6, 0, 4, 2, 0, 3, 1, 8, 4, 0, 0, 9, 0 };
            int[] J = new int[] { 1, 3, 2, 2, 4, 3, 2, 3, 4, 5, 4, 5, 2, 0 };
            int n = 5;
            int[,] a = new int[n, n];
            int col = 0;
            int row = 0;
            for (int i = 0; i < J.Length; i++)
            {
                if (AL[i] == 0)
                {
                    row = J[i] - 1;
                }
                else
                {
                    col = J[i] - 1;
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
