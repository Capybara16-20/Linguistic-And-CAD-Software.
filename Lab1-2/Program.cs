using System;
using System.Collections.Generic;

namespace Lab1_2
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
            AL.Add(0);
            List<int> J = new List<int>();
            J.Add(1);
            int count = 1;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != 0)
                    {
                        AL.Add(a[i, j]);
                        J.Add(j + 1);
                    }
                }
                AL.Add(0);
                count += 1;
                if (count <= n)
                {
                    J.Add(count);
                }
                else
                {
                    J.Add(0);
                }
            }
            Console.Write("AL: ");
            for (int i = 0; i < AL.Count; i++)
            {
                Console.Write(AL[i] + "  ");
            }
            Console.WriteLine();
            Console.Write("J:  ");
            for (int i = 0; i < AL.Count; i++)
            {
                Console.Write(J[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
