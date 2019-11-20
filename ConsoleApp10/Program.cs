using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            sq.Height = -100;
            sq.Width = 20;
            double area = sq.Area();
            Console.WriteLine(area);
        }
    }
}
