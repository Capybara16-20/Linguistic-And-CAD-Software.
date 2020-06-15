using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] Tree = { 0, 1, 1, 3, 3, 4, 4, 5, 5, 6, 6, 10, 10, 11, 11 };
            //char[] Tags = { '=', 'a', '+', '*', '*', '+', 'f', 'g', 'h', '*', '*', 'b', 'c', 'd', 'e' };
            char[] Tags = { '=', 'a', '+', '*', '+', '*', '+', '*', 'h', 'b', 'c', 'd', 'e', 'f', 'g' };
            int[] levels = new int[n];
            List<int> operations = new List<int>();
            List<char> stack = new List<char>();
            List<string> codes = new List<string>();
            string code;

            //Вычисление уровней вершин
            for (int i = n - 1; i >= 0; i--)
            {
                if (char.IsLetter(Tags[i]))
                {
                    levels[i] = 0;
                    stack.Add(Tags[i]);
                }
                else
                {
                    operations.Add(i);
                    if (char.IsDigit(stack[1]))
                    {
                        levels[i] = int.Parse(stack[1].ToString()) + 1;
                    }
                    else if (char.IsDigit(stack[0]))
                    {
                        levels[i] = int.Parse(stack[0].ToString()) + 1;
                    }
                    else
                    {
                        levels[i] = 1;
                    }
                    stack.Add(char.Parse(levels[i].ToString()));
                    stack.RemoveAt(0);
                    stack.RemoveAt(0);
                }
            }
            stack.Clear();

            //Генерация объектных кодов отдельных операторов
            for (int i = n - 1; i > 0; i--)
            {
                if (Char.IsLetter(Tags[i]))
                {
                    stack.Add(Tags[i]);
                }
                else
                {
                    if (char.IsDigit(stack[0]))
                    {
                        code = codes[int.Parse(stack[0].ToString())];
                        code = code + "Load #" + levels[operations[int.Parse(stack[0].ToString())]] + "\n";
                        code = code + "Store #" + levels[i] + "\n";
                        stack.RemoveAt(0);
                    }
                    else
                    {
                        code = "Load " + stack[0] + "\n";
                        code = code + "Store #" + levels[i] + "\n";
                        stack.RemoveAt(0);
                    }
                    if (char.IsDigit(stack[0]))
                    {
                        code = code + codes[int.Parse(stack[0].ToString())];
                        stack.RemoveAt(0);
                    }
                    else
                    {
                        code = code + "Load " + stack[0] + "\n";
                        stack.RemoveAt(0);
                    }

                    if (Tags[i] == '+')
                    {
                        code = code + "Add #" + levels[i] + "\n";
                    }
                    else if (Tags[i] == '*')
                    {
                        code = code + "Mult #" + levels[i] + "\n";
                    }
                    Console.WriteLine("X" + (i + 1));
                    Console.WriteLine(code);
                    stack.Add(char.Parse(codes.Count.ToString()));
                    codes.Add(code);
                }
            }
            code = codes[int.Parse(stack[0].ToString())];
            code = code + "Store " + stack[1] + "\n";
            Console.WriteLine("X1:");
            Console.WriteLine(code);
        }
    }
}
