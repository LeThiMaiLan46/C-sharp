using System;

namespace Baii1
{
    public class SungLuc : Sung
    {
        public SungLuc(string ten, int soBang, int soDan) : base(ten, soBang, soDan)
        {
        }

        public override void Ban()
        {
            base.Ban();
            soDan = soDan - 1;
            Console.WriteLine(soDan);
        }
    }
}