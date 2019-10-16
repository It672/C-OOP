using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j;
            while (i < 3)
            {
                j = 0;
                while (j < 3)
                {
                    Console.Write('*');
                    j++;
                }
                Console.WriteLine();
                i++;
            }

            //j = 0;
            //while (j < 3)
            //{
            //    Console.Write('*');
            //    j++;
            //}
            //Console.WriteLine();

            //j = 0;
            //while (j < 3)
            //{
            //    Console.Write('*');
            //    j++;
            //}
            //Console.WriteLine();


            //int i = 1;
            //int j;
            //while (i <= 3)
            //{
            //    j = 1;
            //    while (j <= 3)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}


        }
    }
}
