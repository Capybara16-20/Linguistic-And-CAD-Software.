using System;

namespace Lab2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 5, 2, 7, 4, 6, 1, 3, 9 };
            int[] I = new int[] { 1, 1, 2, 3, 3, 3, 4, 4 };
            int[] J = new int[] { 2, 3, 3, 2, 4, 5, 2, 5 };
            int n = 5;
            int[,] a = new int[n, n];
            for (int i = 0; i < AL.Length; i++)
            {
                a[I[i] - 1, J[i] - 1] = AL[i];
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
