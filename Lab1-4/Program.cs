using System;
using System.Collections.Generic;

namespace Lab1_4
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

            List<int> AL = new List<int>();
            List<int> J = new List<int>();
            List<int> IC = new List<int>();
            IC.Add(1);
            int sum = 1;
            int countInRow = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i,j] != 0)
                    {
                        countInRow++;
                        AL.Add(a[i, j]);
                        J.Add(j + 1);
                    }
                }
                sum += countInRow;
                IC.Add(sum);
                countInRow = 0;
            }
            //Вывод результата
            Console.Write("AL: ");
            for (int i = 0; i < AL.Count; i++)
            {
                Console.Write(AL[i] + "  ");
            }
            Console.WriteLine();
            Console.Write("J:  ");
            for (int i = 0; i < J.Count; i++)
            {
                Console.Write(J[i] + "  ");
            }
            Console.WriteLine();
            Console.Write("IC: ");
            for (int i = 0; i < IC.Count; i++)
            {
                Console.Write(IC[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
