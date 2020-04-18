using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] keys = new int[,] { { 12, 1000 }, { 3, 3000 }, { 8, 4000 }, { 1, 7000 }, { 6, 5000 },
                                       { 4, 90000 }, { 9, 2000 }, { 11, 800 }, { 7, 1300 }, { 5, 9999 },
                                       { 13, 500 }, { 21, 333 }, { 17, 300 }, { 19, 299 }, { 24, 777 },
                                       { 14, 700 }, { 20, 555 }, { 16, 200 }, { 18, 400 }, { 15, 900 },
                                       { 26, 111 }, { 32, 345 }, { 29, 888 }, { 25, 100 }, { 31, 234 },
                                       { 27, 444 }, { 33, 456 }, { 28, 666 }, { 30, 123 }, { 34, 567 }};*/

            int[,] keys = new int[,] { { 1, 7000 }, { 3, 3000 }, { 4, 90000 }, { 5, 9999 }, { 6, 5000 },
                                       { 7, 1300 }, { 8, 4000 }, { 9, 2000 }, { 11,800 }, { 12, 1000 },
                                       { 13, 500 }, { 14, 700 }, { 15, 900 }, { 16, 200 }, { 17, 300 },
                                       { 18, 400 } ,{ 19, 299 }, { 20, 555 }, { 21, 333 }, { 24, 777 },
                                       { 25, 100 }, { 26, 111 }, { 27, 444 }, { 28, 666 }, { 29, 888 },
                                       { 30, 123 }, { 31, 234 }, { 32, 345 }, { 33, 456 }, { 34, 567 }};
            int compares = 0;
            //int result = LinearSearch(keys, 31, ref compares);
            //int result = BinaryIterativeSearch(keys, 34, ref compares);
            //int result = BinaryRecursiveSearch(keys, 34, 0, 29, ref compares);

            Tree tree = CreateTree(keys);
            int result = TreeSearch(tree, 34, ref compares);

            if (result == 0)
            {
                Console.WriteLine("Не найден");
            }
            Console.WriteLine(compares);
        }

        public static int LinearSearch(int[,] keys, int key, ref int compares)
        {
            for (int i = 0; i < keys.GetLength(0); i++)
            {
                compares++;
                if (keys[i, 0] == key)
                {
                    return keys[i, 1];
                }
            }
            return 0;
        }

        public static int BinaryRecursiveSearch(int[,] keys, int key, int low, int high, ref int compares)
        {
            while (high >= low)
            {
                compares++;
                int p = (low + high) / 2;
                if (keys[p, 0] == key)
                {
                    return keys[p, 1];
                }
                else if (keys[p, 0] > key)
                {
                    return BinaryRecursiveSearch(keys, key, low, p - 1, ref compares);
                }
                else
                {
                    return BinaryRecursiveSearch(keys, key, p + 1, high, ref compares);
                }
            }
            return 0;
        }

        public static int BinaryIterativeSearch(int[,] keys, int key, ref int compares)
        {
            int low = 0;
            int high = keys.GetLength(0) - 1;
            while (low <= high)
            {
                compares++;
                int p = (low + high) / 2;
                if (keys[p, 0] == key)
                {
                    return keys[p, 1];
                }
                else if (keys[p, 0] > key)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return 0;
        }

        public static int TreeSearch(Tree tree, int key, ref int compares)
        {
            int p = 0;
            while (tree.keys[p, 0] != key)
            {
                compares++;
                if (tree.keys[p, 0] > key)
                {
                    compares++;
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
                    compares++;
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
    }
}
