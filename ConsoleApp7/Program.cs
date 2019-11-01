using System;

namespace ConsoleApp7
{
    class Program
    {
        public static int[,] MakeZero(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = j % 2;
                    }

                }
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            int[,] matrix = {
                                { 1, 2, 3, 5, 9, 7, 4 },
                                { 4, 5, 6, 2, 3, 5, 9 },
                                { 7, 8, 9, 6, 2, 3, 5 },
                                { 4, 5, 6, 2, 3, 5, 9 },
                                { 4, 5, 6, 2, 3, 5, 9 },
                                { 4, 5, 6, 2, 3, 5, 9 },
                                { 4, 5, 6, 2, 3, 5, 9 }
                            };

            MakeZero(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
