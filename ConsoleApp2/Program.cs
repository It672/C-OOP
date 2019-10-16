using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void CreateTriangleSymbolPattern(char symbol, int shape)
        {

            for (int i = 0; i < shape; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Olchu: ");
            int shape = int.Parse(Console.ReadLine());
            Console.Write("Symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            CreateTriangleSymbolPattern(symbol, shape);

        }
    }
}
