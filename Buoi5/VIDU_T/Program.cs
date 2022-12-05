using System;
using System.Collections.Generic;

namespace VIDU_T
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            Lop<HS_KiemToan> lopKT = new Lop<HS_KiemToan>(2);
            Lop<HS_CNTT> lopCNTT = new Lop<HS_CNTT>(1);

            //nhap
            for (int i = 0; i < lopKT.hs.Length; i++)
            {
                lopKT.hs[i] = new HS_KiemToan();
                lopKT.hs[i].ho = "KT ho " + i;
                lopKT.hs[i].ten = "KT ten " + i;
            }
            
            for (int i = 0; i < lopCNTT.hs.Length; i++)
            {
                lopCNTT.hs[i] = new HS_CNTT();
                lopCNTT.hs[i].tuoi = i;
                lopCNTT.hs[i].ten = "KT ten " + i;
            }
            
            //xuat
            for (int i = 0; i < lopKT.hs.Length; i++)
            {
                Console.WriteLine(lopKT.hs[i].ho + " " + lopKT.hs[i].ten);
            }
            
            for (int i = 0; i < lopCNTT.hs.Length; i++)
            {
                Console.WriteLine(lopCNTT.hs[i].ten + " Tuoi " + lopCNTT.hs[i].tuoi);
            }
            */

            // list<T>
            
            List<HS_CNTT> lophsCntt = new List<HS_CNTT>();
            lophsCntt.Clear();
            
            //dictionary<key, value>
            
            
        }
    }
}