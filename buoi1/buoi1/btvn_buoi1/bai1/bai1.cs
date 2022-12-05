using System;

namespace bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n, k;
            k = int.Parse("0");
            do
            {
                Console.WriteLine("Nhap vao so nguyen duong:");
                n = int.Parse(n);
                n = Console.ReadLine();
            } while (n <= 0);

            for (int i = 0; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    k = 1;
                    Console.WriteLine("NO");
                }
            }

            if (k == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}