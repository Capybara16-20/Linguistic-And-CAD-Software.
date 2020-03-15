using System;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AL = new int[] { 5, 2, 7, 4, 6, 1, 3, 9 };
            int[] J = new int[] { 2, 3, 4, 6, 4, 5, 2, 5 };
            int[] IC = new int[] { 1, 1, 5, 6, 8, 9, 9 };
            int n = IC.Length - 1;
            int[,] a = new int[n, n];
            int difference = IC[0];
            for (int i = 0; i < IC.Length; i++)
            {
                IC[i] -= difference;
            }
            int row = 0;
            for (int i = 1; i < IC.Length; i++)
            {
                for (int j = IC[i - 1]; j < IC[i]; j++)
                {
                    a[row, J[j] - 1] = AL[j];
                }
                row++;
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
