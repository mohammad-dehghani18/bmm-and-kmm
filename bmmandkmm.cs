using System;
using System.Runtime.InteropServices;

namespace project
{
    class Test
    {
        public static void Main()
        {
            //mohammad dehghani project
            Console.WriteLine("please enter m & n:");
            Console.Write("m = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            int y = Convert.ToInt32(Console.ReadLine());
            kmm (m, n);
            bmm (m, n);
        }
        private static void kmm (int m, int n)
        {
            int temp = 1;
            for (int i = 1; i <= m && i <= n; i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    temp = i;
                }
            }
            int kmm = (m * n) / temp;
            Console.WriteLine("K M M = {0}", kmm);
        }
        private static void bmm(int m, int n)
        {
            int temp = 1;
            for (int i = 1; i <= m && i <= n; i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    temp = i;
                }
            }

            Console.WriteLine("B M M = {0}",temp);
        }
    }
}