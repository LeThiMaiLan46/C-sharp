using System;

namespace btvn_baii2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            PhanSo[] a = new PhanSo[n];
            
            //nhap
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Phan so thu " + (i+1));
                Console.Write("Tu so = ");
                a[i].tuSo = int.Parse(Console.ReadLine());
                Console.Write("Mau so = ");
                a[i].mauSo = int.Parse(Console.ReadLine());
            }
            
            //xuat
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].Chia() > a[j].Chia())
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.Write(a[i].tuSo + "/" + a[i].mauSo + "     ");
            }
        }

        struct PhanSo
        {
            public int tuSo;
            public int mauSo;

            public double Chia()
            {
                return (double) tuSo / mauSo;
            }
        }
    }
}