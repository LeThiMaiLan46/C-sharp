using System;

namespace Baii1
{
    public class SungTruong : Sung
    {
        private bool dao;
        public override void Ban()
        {
            base.Ban();
            soDan -= 3;
            Console.WriteLine(soDan);
        }

        public void Ngam()
        {
            Console.WriteLine("Ngam ....");
        }
        public SungTruong(string ten, int soBang, int soDan, bool dao) : base(ten, soBang, soDan)
        {
            this.dao = dao;
        }
    }
}