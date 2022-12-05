using System;

namespace Baii1
{
    public class Sung
    {
        public Sung(string ten, int soBang, int soDan)
        {
            this.ten = ten;
            this.soBang = soBang;
            this.soDan = soDan;
        }

        protected string ten;
        protected int soBang;
        protected int soDan;

        public virtual void Ban()
        {
            Console.Write("Ten: " + ten + "\tSo bang: " + soBang + "\tSo dan: " + soDan + "\tSo dan con lai: ");
        }
    }
}