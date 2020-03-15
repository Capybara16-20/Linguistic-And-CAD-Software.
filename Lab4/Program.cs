using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Separator();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ключи имеют случайные значения");
            Console.ResetColor();
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 5  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 10  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 15  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 20  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 25  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 30  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11, 9, 8, 10, 1, 3 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11, 9, 8, 10, 1, 3 });
            ChoiceSortInfoOutput(new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14, 9, 1, 5, 2, 11, 6, 8, 3, 7, 4, 7, 2, 9, 5, 11, 9, 8, 10, 1, 3 });
            Separator();



            Separator();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Значения ключей почти упорядочены");
            Console.ResetColor();
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 5  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 3, 8, 4, 7, 12 });
            SimpleInsertsSortInfoOutput(new int[] { 3, 8, 4, 7, 12 });
            ChoiceSortInfoOutput(new int[] { 3, 8, 4, 7, 12 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 10  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 0, 3, 3, 10, 4, 6, 7, 8, 12, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 0, 3, 3, 10, 4, 6, 7, 8, 12, 14 });
            ChoiceSortInfoOutput(new int[] { 0, 3, 3, 10, 4, 6, 7, 8, 12, 14 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 15  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 4, 10, 5, 6, 7, 8, 9, 11, 12, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 4, 10, 5, 6, 7, 8, 9, 11, 12, 14 });
            ChoiceSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 4, 10, 5, 6, 7, 8, 9, 11, 12, 14 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 20  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 3, 4, 4, 10, 5, 6, 6, 7, 7, 8, 8, 9, 11, 12, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 3, 4, 4, 10, 5, 6, 6, 7, 7, 8, 8, 9, 11, 12, 14 });
            ChoiceSortInfoOutput(new int[] { 0, 1, 2, 3, 3, 3, 4, 4, 10, 5, 6, 6, 7, 7, 8, 8, 9, 11, 12, 14 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 25  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 11, 11, 12, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 11, 11, 12, 14 });
            ChoiceSortInfoOutput(new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 9, 9, 11, 11, 12, 14 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 30  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 0, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 11, 11, 12, 14 });
            SimpleInsertsSortInfoOutput(new int[] { 0, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 11, 11, 12, 14 });
            ChoiceSortInfoOutput(new int[] { 0, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 10, 5, 5, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 11, 11, 12, 14 });
            Separator();


            Separator();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Значения ключей в обратном порядке");
            Console.ResetColor();
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 5  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 12, 8, 7, 4, 3 });
            SimpleInsertsSortInfoOutput(new int[] { 12, 8, 7, 4, 3 });
            ChoiceSortInfoOutput(new int[] { 12, 8, 7, 4, 3 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 10  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 14, 12, 10, 8, 7, 6, 4, 3, 3, 0 });
            SimpleInsertsSortInfoOutput(new int[] { 14, 12, 10, 8, 7, 6, 4, 3, 3, 0 });
            ChoiceSortInfoOutput(new int[] { 14, 12, 10, 8, 7, 6, 4, 3, 3, 0 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 15  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 3, 2, 1, 0 });
            SimpleInsertsSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 3, 2, 1, 0 });
            ChoiceSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 3, 2, 1, 0 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 20  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 8, 7, 7, 6, 6, 5, 4, 4, 3, 3, 3, 2, 1, 0 });
            SimpleInsertsSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 8, 7, 7, 6, 6, 5, 4, 4, 3, 3, 3, 2, 1, 0 });
            ChoiceSortInfoOutput(new int[] { 14, 12, 11, 10, 9, 8, 8, 7, 7, 6, 6, 5, 4, 4, 3, 3, 3, 2, 1, 0 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 25  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 9, 9, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 2, 2, 1, 0 });
            SimpleInsertsSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 9, 9, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 2, 2, 1, 0 });
            ChoiceSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 9, 9, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 2, 2, 1, 0 });
            Separator();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("n = 30  /");
            Console.ResetColor();
            LowSeparator();
            SwapSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 10, 9, 9, 9, 8, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 1, 1, 0 });
            SimpleInsertsSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 10, 9, 9, 9, 8, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 1, 1, 0 });
            ChoiceSortInfoOutput(new int[] { 14, 12, 11, 11, 10, 10, 9, 9, 9, 8, 8, 8, 7, 7, 7, 6, 6, 5, 5, 4, 4, 3, 3, 3, 3, 2, 2, 1, 1, 0 });
            Separator();

            Console.ReadKey();
        }

        static void SwapSortInfoOutput(int[] arr)
        {
            int compareCount = default(int);
            int reverseCount = default(int);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    compareCount++;
                    if ((i != j) && (arr[i] < arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        reverseCount++;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Обменами:");
            Console.ResetColor();
            Console.Write("Число сравнений:    [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(compareCount);
            Console.ResetColor();
            Console.Write("]" + "\n" + "Число перестановок: [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(reverseCount);
            Console.ResetColor();
            Console.WriteLine("]");
        }

        static void SimpleInsertsSortInfoOutput(int[] arr)
        {
            int compareCount = default(int);
            int reverseCount = default(int);
            int s = default(int);
            for (int i = 1; i < arr.Length; i++)
            {
                s = arr[i];
                int index = i - 1;
                compareCount++;
                while ((index >= 0) && (arr[index] > s))
                {
                    compareCount++;
                    reverseCount++;
                    arr[index + 1] = arr[index];
                    index--;
                }
                arr[index + 1] = s;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Вставками:");
            Console.ResetColor();
            Console.Write("Число сравнений:    [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(compareCount);
            Console.ResetColor();
            Console.Write("]" + "\n" + "Число перестановок: [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(reverseCount);
            Console.ResetColor();
            Console.WriteLine("]");
        }

        static void ChoiceSortInfoOutput(int[] arr)
        {
            int compareCount = default(int);
            int reverseCount = default(int);
            for (int i = 0; i < arr.Length; i++)
            {
                int min = int.MaxValue;
                int min_index = default(int);
                for (int j = i; j < arr.Length; j++)
                {
                    compareCount++;
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        min_index = j;
                    }
                }
                reverseCount++;
                int temp = arr[i];
                arr[i] = min;
                arr[min_index] = temp;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Выбором:");
            Console.ResetColor();
            Console.Write("Число сравнений:    [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(compareCount);
            Console.ResetColor();
            Console.Write("]" + "\n" + "Число перестановок: [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(reverseCount);
            Console.ResetColor();
            Console.WriteLine("]");
        }

        static void Separator()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        static void LowSeparator()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("-");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
