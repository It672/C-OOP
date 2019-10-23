using System;
using System.Collections.Generic;

namespace Count_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World, Hello Universe and 672";
            string sentencelw = sentence.ToLower();
            var dict = new Dictionary<string, int>();
            var words = sentencelw
                        .Split(new string[] { ",", " " },
                        StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict[item] = 1;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
