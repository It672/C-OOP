using System;

namespace ConsoleApp8
{
    public delegate void CustomEventHandler();
    class Program
    {
        public static event CustomEventHandler _show ;
        static void Main(string[] args)
        {
            _show += new CustomEventHandler(Dog);
            _show += new CustomEventHandler(Cat);
            _show += new CustomEventHandler(Mouse);
            _show += new CustomEventHandler(Mouse);

            _show -= new CustomEventHandler(Cat);
            _show.Invoke();
        }
        static void Cat()
        {
            Console.WriteLine("Cat");
        }

        static void Dog()
        {
            Console.WriteLine("Dog");
        }

        static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
    }
}
