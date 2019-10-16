using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            //int[] a = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //for (int i = 0; i <a.Length; i++)
            //{
            //    sum += a[i];


            //}
            //Console.WriteLine(sum);
            //int max = a[0];
            //int max2 = a[0];
            //int max3 = a[0];
            //for (int i = 1; i < a.Length; i++)
            //{



            //    if (max < a[i])
            //    {
            //        max3 = max2;
            //        max2 = max;
            //        max = a[i];


            //    }
            //    else if (a[i] > max2)
            //    {

            //        if (max2 < max3)
            //        {
            //            max3 = a[i];

            //        }
            //        max2 = a[i];
            //    }



            //}
            //Console.WriteLine(max);
            //   int[,] a = new int[2, 2] {
            //   {
            //      1,
            //      2
            //   }, {
            //      3,
            //      4
            //   }
            //};

            //int i, j;
            //int[] b = new int[4];
            //int k = 0;

           

            //Console.WriteLine("1d");
            //for (i = 0; i < 2; i++)
            //{
            //    for (j = 0; j < 2; j++)
            //    {
            //        b[k++] = a[i, j];
            //    }
            //}

            //for (i = 0; i < 2 * 2; i++)
            //{
            //    Console.Write("{0}", b[i]);
            //}


            //int m = 0;
            //int n;
            //n = Convert.ToInt32(Console.ReadLine());
            //bool check = false;
            //m = n / 2;

            //for (int i = 2; i <= m; i++)
            //{
            //    if (n%i==0)
            //    {
            //        check = true;
            //        Console.WriteLine("Not Prime");
            //        break;
            //    }

            //}


            //if (check==false)
            //{
            //    Console.WriteLine(" Prime");
            //}

            int hour=Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());

            if (hour<0 || minute<0 || minute>60 || hour > 12)
            {

                Console.WriteLine("Wrong");
            }
            if (hour == 12)
            {
                hour = 0;
            }
            if (minute == 60)
            {
                minute = 0;
            }
            int h_angle = (int)((hour * 60 + minute)*0.5);
            int m_angle = (int)(6 * minute);
            int diff = Math.Abs(h_angle - m_angle);

            diff = Math.Min(360 - diff, diff);
            Console.WriteLine(diff);
            Console.Read();


        }
    }
}
