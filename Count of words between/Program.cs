using System;
using System.Collections.Generic;

namespace Count_of_words_between
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World ABC BCA Hello";
            string sentencelw = sentence.ToLower();
            string splitword="";
            var dict = new Dictionary<string, int>();


            foreach (var item in sentencelw.Split(" "))
            {
                if (dict.ContainsKey(item)) 
                { 
                    splitword = item;
                    break;    
                }
                else
                    dict[item] = 1;
            }
            var fragtions = sentencelw.Split(splitword);
            var wordsBetweenSentence = fragtions[1];
            var wordsBetweenArr = wordsBetweenSentence.Split(" ",
                                        StringSplitOptions.RemoveEmptyEntries);
            var countofWords = wordsBetweenArr.Length;
            Console.WriteLine(countofWords);
            

        }
    }
}
