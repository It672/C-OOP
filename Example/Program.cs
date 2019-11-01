using System;

namespace Example
{
    class Program
    {
        delegate int[] ArraySortDelegate(int[] arr);

        static int[] ArraySortASC(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                    }
                }
            }
            return arr;
        }
        static int[] ArraySortDESC(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 9 };
            ArraySortDelegate del = new ArraySortDelegate(ArraySortASC);
            int[] r = del(array);

            Console.WriteLine("Ascending:");
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine($"r[{i}] = {r[i]}");
            }

            Console.WriteLine("Descending:");
            del = new ArraySortDelegate(ArraySortDESC);
            del(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

        }
    }
}
