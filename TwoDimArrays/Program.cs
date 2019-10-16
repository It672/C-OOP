using System;

namespace TwoDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int max;
            int replace;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                max = mat[i, 0];
                replace = mat[i, 0];
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (max < mat[i, j])
                    {
                        max = mat[i, j];
                    }  
                }

                
                mat[i, 0] = max;

            }


            for(int g = 0; g < mat.GetLength(0); g++)
            {
                for(int y=0;y<mat.GetLength(1); y++)
                {
                    Console.Write(mat[g,y]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
