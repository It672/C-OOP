using System;

namespace DelegateMethods
{
    class Program
    {
        delegate int MathCalc(int a, int b);
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multi(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            MathCalc del = new MathCalc(Add);

            int result = del(5, 6);
            Console.WriteLine(result);

            del = new MathCalc(Multi);

            result = del(5, 6);
            Console.WriteLine(result);

            del = new MathCalc(Div);

            result = del(5, 6);
            Console.WriteLine(result);

            del = new MathCalc(Sub);

            result = del(5, 6);
            Console.WriteLine(result);
        }
    }
}

