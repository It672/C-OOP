using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = "Yusif A11, Fidan 11B sinfinde oxuyur";
         
            int count = 0;
            for (int i = 0; i < m.Length-1; i++)
            {
                if (char.IsDigit(m[i]) && 
                    (char.IsLetter(m[i-1]) ||  char.IsLetter(m[i + 1])))
                {
                   
                       count++;
                    
                }
                 
            }Console.WriteLine(count);
        }
    }
}
