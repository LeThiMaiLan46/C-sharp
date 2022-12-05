using System;

namespace bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HocSinh hs = new HocSinh("Mai Lan", "KTPM01", 9.5);
            Console.WriteLine(hs.ToString());
        }
    }

    class HocSinh
    {
        private string ten;
        private string lop;
        private double diem;

        public HocSinh(string ten, string lop, double diem)
        {
            this.ten = ten;
            this.lop = lop;
            this.diem = diem;
            if (this.diem > 10)
            {
                this.diem = 10;
            }

            if (this.diem < 0)
            {
                this.diem = 0;
            }
        }

        private string GetHocBong()
        {
            if (diem < 8)
            {
                return "khong dat Hoc Bong";
            }
            else
            {
                return "dat Hoc Bong";
            }
        }
        public override string ToString()
        {
            return ten + "\t" + lop + "\t" + diem + "\t" + GetHocBong() + "\n";
        }
    }
}