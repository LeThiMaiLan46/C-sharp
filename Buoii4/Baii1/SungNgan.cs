using System;

namespace Baii1
{
    public class SungNgan : Sung
    {
        public override void Ban()
        {
            base.Ban();
            soDan = soDan - 2;
            Console.WriteLine(soDan);
        }

        public SungNgan(string ten, int soBang, int soDan) : base(ten, soBang, soDan)
        {
        }
    }
}