using System;

namespace Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //struct gán giá trị (public), class gán ô nhớ (private)
            // HocSinh a = new HocSinh("Mai Lan ", 19, " KTPM01");
            // a.Tuoi = 5; //gọi hàm set đặt tuổi = 5
            // Console.WriteLine(a.Tuoi); //gọi hàm get
            
            
            
        }
    }
    /*
    public class HocSinh
    {
        //khai bao o tren
        public HocSinh(string ten, int tuoi, string lop)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.lop = lop;
        }

        private string ten;  //this.ten tra ve ten
        private int tuoi;
        private string lop;

        /
        public void SetTuoi(int tuoi)
        {
            if (tuoi < 0)
            {
                return;
            }
            this.tuoi = tuoi;
        }

        public int GetTuoi()
        {
            return tuoi;
        }
        /

        public int Tuoi
        {
            get
            {
                return this.tuoi;
            }
            set
            {
                tuoi = value;
            }
        }

        public void SetTuoiByString(string tuoi)
        {
            this.tuoi = int.Parse(tuoi);
        }

        public override string ToString() //mỗi class đều có sẵn tostring, dùng override..tostring để ghi đè bằng string
        {
            return ten + tuoi + lop;
        }
    } 
    */

    public class HocSinh
    {
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int Tuoi1
        {
            get => tuoi;
            set => tuoi = value;
        }

        public int Tuoi => tuoi;

        public string Lop => lop;

        public HocSinh(string ten, int tuoi)
        {
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public HocSinh(int tuoi, string lop)
        {
            this.tuoi = tuoi;
            this.lop = lop;
        }

        private string ten;
        private int tuoi;
        private string lop;
    }
}