using System;

namespace bai2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap vao so nguyen duong:");
                n = Console.ReadLine();
            } while (n <= 0);

            for (int i = 0; i <= n / 2; i++)
            {
                if (i * i * i == n)
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}