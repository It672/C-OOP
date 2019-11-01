using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("it is prime");
            }
            else
            {
                Console.WriteLine("it is not prime");
            }
        }
    }
}
