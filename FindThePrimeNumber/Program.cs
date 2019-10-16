using System;

namespace FindThePrimeNumber
{
    class Program
    {
        public static void PrimeNumbers(int begin,int end)
        {    
            for (int i = begin; i <= end; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool CheckPrime(int i)
        {
            bool prime = true;
            for (int j = 2; j < i/2; j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }

        static void Main(string[] args)
        {
            PrimeNumbers(5, 23);
        }
    }
}
