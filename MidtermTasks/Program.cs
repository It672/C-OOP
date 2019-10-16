using System;

namespace MidtermTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { {1, 2 ,3 },
                          { 3, 4, 5 },
                          { 6, 7, 3 } };
        int max;
        for(int i = 0; i < arr.GetLength(0); i++)
            {
                max = arr[0, i];
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                arr[i, 0] = max;
                for(int g = 0; g < arr.GetLength(0); g++)
                {
                    for(int f = 0; f < arr.GetLength(1); f++)
                    {
                        Console.WriteLine(arr[g, f] + " ");
                    }
                }
            }
           

        }
    }
}

