using System;
using System.Collections.Generic;

namespace Lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] a = { { 0, 5, 4, 3, 0 },
                         { 0, 7, 6, 0, 0 },
                         { 0, 8, 0, 0, 1 },
                         { 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 2, 3 } };

            List<int> AL = new List<int>();
            AL.Add(0);
            List<int> I = new List<int>();
            I.Add(1);
            int count = 1;
            for (int j = 0; j < n; j++)
            {

                for (int i = 0; i < n; i++)
                {
                    if (a[i, j] != 0)
                    {
                        AL.Add(a[i, j]);
                        I.Add(i + 1);
                    }
                }
                AL.Add(0);
                count += 1;
                if (count <= n)
                {
                    I.Add(count);
                }
                else
                {
                    I.Add(0);
                }

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("AL: ");
            for (int i = 0; i < AL.Count; i++)
            {
                Console.Write(AL[i] + "  ");
            }
            Console.WriteLine();
            Console.Write("I:  ");
            for (int i = 0; i < AL.Count; i++)
            {
                Console.Write(I[i] + "  ");
            }
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
