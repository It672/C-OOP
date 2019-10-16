using System;

namespace IntroductionToMethods
{
    class Program
    {
        public static int[] ModifyArray(int[] a)
        {
            int[] localArray = a;
            for (int i = 0; i < localArray.Length; i++)
            {
                localArray[i] = localArray[i] * 10;
            }

            return localArray;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(a);
           // int[] result = ModifyArray(a);
            PrintArray(ModifyArray(a));
            PrintArray(a);
        }
    }
}
