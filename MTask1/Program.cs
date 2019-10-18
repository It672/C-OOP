using System;

namespace MTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 15;
            int max = a;
            if (max<b)
            {
                max = b;
            }
            if (max<c)
            {
                max = c;
            }
            Console.WriteLine(max);
        }
    }
}
