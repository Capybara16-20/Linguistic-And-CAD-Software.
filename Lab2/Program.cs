using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод сортировки обменами
            int[] arr = new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((i != j) && (arr[i] < arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

            //Метод сортировки простыми вставками
            arr = new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 };
            int s = default(int);
            for (int i = 1; i < arr.Length; i++)
            {
                s = arr[i];
                int index = i - 1;
                while ((index >= 0) && (arr[index] > s))
                {
                    arr[index + 1] = arr[index];
                    index--; 
                }
                arr[index + 1] = s;
            }
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

            //Метод сортировки выбором
            arr = new int[] { 12, 4, 3, 7, 8, 3, 0, 10, 6, 14 };
            for (int i = 0; i < arr.Length; i++)
            {
                int min = int.MaxValue;
                int min_index = default(int);
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        min_index = j;
                    }
                }
                int temp = arr[i];
                arr[i] = min;
                arr[min_index] = temp;
            }
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
