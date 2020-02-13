using System;

namespace Lab2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 5, 2, 7, 4, 6, 1, 3, 9 };
            int[] k = new int[] { 6, 11, 12, 8, 18, 23, 9, 24 };
            int n = 5;
            int row = 0;
            int col = 0;
            int[,] a = new int[n, n];
            for (int i = 0; i < AL.Length; i++)
            {
                EquationSolution(k[i], n, ref row, ref col);
                a[row - 1, col - 1] = AL[i];
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

        public static void EquationSolution(int k, int n, ref int i, ref int j)
        {
            int a;
            int b = 0;
            do
            {
                b++;
                a = k - n * b + n;
            }
            while (a > 5);
            i = a;
            j = b;
        }
    }
}
