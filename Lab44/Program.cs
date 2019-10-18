using System;

namespace Lab44
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int n = Int32.Parse(arr_temp[0]);
            int d = Int32.Parse(arr_temp[1]);

            string[] arr = Console.ReadLine().Split(' ');
            string[] ans = new string[n];

            for (int i = 0; i < n; ++i)
            {
                ans[(i + n - d) % n] = arr[i];
            }

            for (int j = 0; j < n; ++j)
            {
                Console.Write(ans[j] + " ");
            }
        }
    }
}   

