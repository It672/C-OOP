using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string samit = "qwrtyipsdfghjklzxcvbnm";
        
            int samitcounter = 0;
            int saitcounter = 0;
            string cumle = "hello world";

            foreach (var herf in cumle.ToLower())
            {
                if (char.IsLetter(herf))    
                {
                    if (samit.Contains(herf))
                    {
                        samitcounter++;
                    }
                    else
                    {
                        saitcounter++;
                    }
                }

            }
            Console.WriteLine("samitlerin sayi: "+samitcounter+" "+"saitlerin sayi: "+saitcounter);
        }
    }
}
