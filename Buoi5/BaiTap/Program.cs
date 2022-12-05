using System;
using System.Collections.Generic;
using System.Threading;

namespace BaiTap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int soLuongHs;
            
            List<HocSinh> lop = new List<HocSinh>();
            Console.WriteLine("Nhap so hoc sinh ");
            soLuongHs = int.Parse(Console.ReadLine());

            HocSinh hs;
            for (int i = 1; i <= soLuongHs; i++)
            {
                hs = new HocSinh();
                Console.WriteLine("Nhap ten hoc sinh thu " + i);
                hs.ten = Console.ReadLine();
                Console.WriteLine("Nhap diem hoc sinh thu " + i);
                hs.diem = double.Parse(Console.ReadLine());
                lop.Add(null);
            }
            
            // sắp xếp bằng cách truyền vào hàm Comparison(bên dưới) và để nó tự sắp xếp
            lop.Sort(Comparison);

            // in ra
            for (int i = 1; i <= lop.Count; i++)
            {
                Console.WriteLine(lop[i].ToString());
            }
            
            // nhập dữ liệu của học sinh mới
            Console.WriteLine("Nhap ten hoc sinh moi:");
            hs = new HocSinh();
            hs.ten = Console.ReadLine();
            hs.diem = double.Parse(Console.ReadLine());
            
            // nếu số học sinh nhỏ hơn 0 thì không truy xuất được phần tử 0
            if (lop.Count > 0)
            {
                if (hs.diem <= hs[0].diem)
                {
                    lop.Insert(0, hs);
                }
                else
                {
                    // nếu bị kệp giwuax i và i+1 thì chèn vaod và thoát for
                    for (int i = 0; i < lop.Count; i++)
                    {
                        if (hs.diem >lop[i].diem && hs.diem <= lop[i+1].diem)
                        {
                            lop.Insert(i+1, hs);
                            break;
                        }
                    }
                    //nếu nó lớn nhất
                    lop.Insert(lop.Count+1, hs);
                }
            }
        }
        
        // ham sap xep
        private static int Comparison(HocSinh x, HocSinh y)
        {
            if (x.diem <= y.diem)
            {
                return 0; // 0 doi cho
            }
            else
            {
                return 1; // doi cho
            }
        }
    }
}