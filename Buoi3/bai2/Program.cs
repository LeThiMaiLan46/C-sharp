using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Lop lop = new Lop();
            lop.Nhap();
            Console.WriteLine(lop.ToString());
        }
    }

    public class Lop
    {
        public string TenLop => _tenLop;

        private HocSinh[] _hocSinhs;
        private string _tenLop;

        // Property chỉ cho phép get
        public int SoLuongHocSinh
        {
            get { return _hocSinhs.Length; }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ten lop");
            _tenLop = Console.ReadLine();
            
            Console.WriteLine("Nhap so luong hs");
            // Cấp phát bộ nhớ cho mảng
            _hocSinhs = new HocSinh[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < _hocSinhs.Length; i++)
            {
                _hocSinhs[i] = new HocSinh();
                
                // Một lớp gọi hàm nhập sẽ tự truyền chính nó và học sinh
                _hocSinhs[i].Nhap(this);
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < _hocSinhs.Length; i++)
            {
                output += _hocSinhs[i].ToString();
            }

            return output;
        }
    }

    public class HocSinh
    {
        private string _ten;
        private Lop _lop;
        private float _diem;

        public void Nhap(Lop lop)
        {
            Console.WriteLine("Nhap ten hoc sinh");
            _ten = Console.ReadLine();
            _lop = lop;
            Console.WriteLine("Nhap diem");
            _diem = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return _ten + "\t" +  _diem + "\t" + DatHb() + "\t" + _lop.TenLop + "\n";
        }

        // Không cho lớp khác gọi được hàm này
        private string DatHb()
        {
            if (_diem < 8)
            {
                return "KoDAT";
            }
            return "DAT";
        }
    }
}