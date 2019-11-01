using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=1258;
            int inverse = 0;
            int remainder = 0;
            while (number>0)
            {
                remainder = number % 10;
                inverse = inverse*10 + remainder;
                number = number/10;
            }
            Console.WriteLine(inverse);
        }
    }
}
