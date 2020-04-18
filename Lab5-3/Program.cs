using System;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] keys = new int[,] { { 12, 1000 }, { 3, 3000 }, { 8, 4000 }, { 1, 7000 }, { 6, 5000 },
                                       { 4, 90000 }, { 9, 2000 }, { 11, 800 }, { 7, 1300 }, { 5, 9999 } };
            int result = 0;

            Console.Write("Введите значение ключа искомой записи: ");
            if (int.TryParse(Console.ReadLine(), out int key))
            {
                Tree tree = CreateTree(keys);
                result = TreeSearch(tree, key);

                if (result == 0)
                {
                    Console.WriteLine("Запись не найдена");
                }
                else
                {
                    Console.WriteLine("Искомая запись: {0}", result);
                }
            }
            else
            {
                Console.WriteLine("Введён некорректный ключ!");
            }
        }

        public static Tree CreateTree(int[,] keys)
        {
            int length = keys.GetLength(0);
            Tree tree = new Tree(keys, new int[length], new int[length]);
            for (int i = 1; i < length; i++)
            {
                int currentIndex = 0;
                while (true)
                {
                    if (keys[i, 0] > tree.keys[currentIndex, 0])
                    {
                        if (tree.rightChilds[currentIndex] == 0)
                        {
                            tree.rightChilds[currentIndex] = i;
                            break;
                        }
                        else
                        {
                            currentIndex = tree.rightChilds[currentIndex];
                        }
                    }
                    else
                    {
                        if (tree.leftChilds[currentIndex] == 0)
                        {
                            tree.leftChilds[currentIndex] = i;
                            break;
                        }
                        else
                        {
                            currentIndex = tree.leftChilds[currentIndex];
                        }
                    }
                }
            }
            return tree;
        }

        public static int TreeSearch(Tree tree, int key)
        {
            int p = 0;
            while (tree.keys[p, 0] != key)
            {
                if (tree.keys[p, 0] > key)
                {
                    if (tree.leftChilds[p] == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        p = tree.leftChilds[p];
                    }
                }
                else
                {
                    if (tree.rightChilds[p] == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        p = tree.rightChilds[p];
                    }
                }
            }
            return tree.keys[p, 1];
        }

        public struct Tree
        {
            public int[,] keys;
            public int[] leftChilds;
            public int[] rightChilds;
            public Tree(int[,] keys, int[] leftChilds, int[] rightChilds)
            {
                this.keys = keys;
                this.leftChilds = leftChilds;
                this.rightChilds = rightChilds;
            }
        }
    }
}
