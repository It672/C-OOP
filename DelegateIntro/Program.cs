using System;

namespace DelegateIntro
{
    class Program
    {
        delegate string UppercaseDelegate(string input);

        static string UppercaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }

        static string UppercaseLast(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);
            return new string(buffer);
        }

        static string UppercaseAll(string input)
        {
            return input.ToUpper();
        }

        //static void WriteOutput(string input, UppercaseDelegate del)
        //{
        //    Console.WriteLine("Your string before: {0}", input);
        //    Console.WriteLine("Your string after: {0}", del(input));
        //}
        static void Main(string[] args)
        {
            string input = "adnsu";
            UppercaseDelegate del = new UppercaseDelegate(UppercaseFirst);
            string result = del(input);
            Console.WriteLine(result);

            del = new UppercaseDelegate(UppercaseLast);
            result = del(input);
            Console.WriteLine(result);

            del = new UppercaseDelegate(UppercaseAll);
            result = del(input);
            Console.WriteLine(result);
            //WriteOutput("perls", new UppercaseDelegate(UppercaseFirst));
            //WriteOutput("perls", new UppercaseDelegate(UppercaseLast));
            //WriteOutput("perls", new UppercaseDelegate(UppercaseAll));
        }
    }
}
