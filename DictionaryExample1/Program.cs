using System;
using System.Collections.Generic;

namespace DictionaryExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("dog", 1);
            dict.Add("cat", 2);
            dict["dog"]++;
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            bool contains = dict.ContainsKey("dog");
            Console.WriteLine(contains);
        }
    }
}
