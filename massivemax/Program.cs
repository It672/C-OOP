using System;
using System.Linq;

namespace massivemax
{
    class Program
    {
        public static void MaxInRow(int[,] arr)
        {
            int max;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                max = ArrayMax(GetRow(arr,i));
                Console.WriteLine((i + 1) + "th row: " + max);
            }

            
        }

        public static int ArrayMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                max = arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {1,5,2 },
                {4,12,13 },
                {14,3,11 }
            };
            MaxInRow(arr);
        }

        static int[] GetRow(int[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();

        }
    }
}
