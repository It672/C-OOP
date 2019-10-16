using System;

namespace ConsoleApp3
{
    class Program
    {
        public static int FindMaxInArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
                return max;
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 7, 8, 9 };
            Console.WriteLine("Initial Array: ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Maximum value in array: ");
            int max = FindMaxInArray(a);
            Console.WriteLine();

        }
    }
}
