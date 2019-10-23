using System;
using System.Collections.Generic;

namespace MrPHPDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] arr = { 1, 2, 3, 1, 2 };
            foreach (int item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++; 
                }
                else 
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

        }
    }
}
