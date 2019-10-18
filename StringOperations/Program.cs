using System;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Agacda 5 alma var";
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    result += s[i];
                }
            }
            Console.WriteLine(  result);
        }
    }
}
