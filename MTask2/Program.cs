using System;

namespace MTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15473;
            int total = 0;
            int reminder = 0;
            int step = 1;
            while (number > 0)
            {
                Console.WriteLine($"Step #{step}");
                Console.WriteLine($"Number: {number}");                
                reminder = number % 10;
                Console.WriteLine($"Reminder: {reminder}");
                total += reminder;
                Console.WriteLine($"Total: {total}");
                number = number / 10;
                Console.WriteLine($"The latest value of the Number in #{step} is {number}");
                Console.WriteLine();
                step++;
            }

            Console.WriteLine(total);
        }
    }
}
