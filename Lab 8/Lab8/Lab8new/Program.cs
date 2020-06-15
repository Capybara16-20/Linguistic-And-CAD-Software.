using System;
using System.IO;

namespace Lab8new
{
    class Program
    {
        public struct Top
        {
            public int left;
            public int right;
            public string code;
        }

        static void Main(string[] args)
        {
            const int n = 15;
            int[] Tree = { 0, 1, 1, 3, 3, 4, 4, 5, 5, 6, 6, 10, 10, 11, 11 };
            char[] Tags = { '=', 'a', '+', '*', '*', '+', 'f', 'g', 'h', '*', '*', 'b', 'c', 'd', 'e' };
            int[] levels = new int[n];
            Top[] tops = new Top[n];

            Levels(n, Tags, levels);

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(levels[i]);
            }*/

            CreateTree(n, Tree, tops);
            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine("left: " + tops[i].left + "; right: " + tops[i].right);
            }*/

            string code = Generate(n, Tree, Tags, levels, tops);
            Console.WriteLine(code);

        }

        //Генерация объектных кодов отдельных операторов
        public static string Generate(int n, int[] Tree, char[] Tags, int[] levels, Top[] tops)
        {
            int right;
            int left;
            for (int i = 0; i < n; i++)
            {
                if (levels[i] == 0)
                {
                    tops[i].code = Tags[i].ToString();
                }
            }
            int level = 1;
            while (level <= levels[0])
            {
                for (int i = 0; i < n; i++)
                {
                    if (levels[i] == level)
                    {
                        if ((tops[i].left != 0) && (tops[i].right != 0))
                        {
                            if (Tags[i] == '+')
                            {
                                right = tops[i].right;
                                left = tops[i].left;
                                tops[i].code = tops[right].code + "\n" + "Store #" + level + "\n" + "Load " + tops[left].code + "\n" + "Add #" + level;
                            }
                            else if (Tags[i] == '*')
                            {
                                right = tops[i].right;
                                left = tops[i].left;
                                tops[i].code = tops[right].code + "\n" + "Store #" + level + "\n" + "Load " + tops[left].code + "\n" + "Mult #" + level;
                            }
                            else
                            {
                                right = tops[i].right;
                                left = tops[i].left;
                                tops[i].code = "Load " + tops[right].code + "\n" + "Store " + tops[left].code;
                            }
                        }
                    }
                }
                level++;
            }

            return tops[0].code;
        }

        //Создание дерева
        public static void CreateTree(int n, int[] Tree, Top[] tops)
        {
            for (int i = 1; i < n; i++)
            {
                int top = Tree[i] - 1;
                if (tops[top].left == 0)
                {
                    tops[top].left = i;
                }
                else
                {
                    tops[top].right = i;
                }
            }
        }

        //Вычисление уровней вершин
        public static void Levels(int n, char[] Tags, int[] levels)
        {
            int index = 0;
            char[] array = new char[n];

            for (int i = n - 1; i >= 0; i--)
            {
                if (char.IsLetter(Tags[i]))
                {
                    levels[i] = 0;
                    array[index] = Tags[i];
                    index++;
                }
                else
                {
                    if (char.IsDigit(char.Parse(array[1].ToString())))
                    {
                        levels[i] = int.Parse(array[1].ToString()) + 1;
                    }
                    else if (char.IsDigit(char.Parse(array[0].ToString())))
                    {
                        levels[i] = int.Parse(array[0].ToString()) + 1;
                    }
                    else
                    {
                        levels[i] = 1;
                    }
                    array[index] = char.Parse(levels[i].ToString());
                    index++;
                    array[0] = '0';
                    array[1] = '0';
                    while (array[0] == '0')
                    {
                        for (int j = 1; j < n; j++)
                        {
                            array[j - 1] = array[j];
                        }
                        index--;
                    }
                }
            }
        }
    }
}
