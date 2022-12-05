using System;

namespace bai3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            n = Console.ReadLine();
            int[] a = new int[n];
            Nhap(a, ref n);
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] % 2 != 0 && a[j] % 2 != 0 && a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Xuat(a, n);
        }

        static void Nhap(int[] a, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + "[" + i "]");
                a[i] = Console.ReadLine();
            }
        }

        static void Xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]) + "  ";
            }
        }
    }
}