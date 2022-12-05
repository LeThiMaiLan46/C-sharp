using System;

namespace Bai1
{
    public class Student : Person
    {
        private string lop;

        public string Lop
        {
            get => lop;
            set => lop = value;
        }

        public override void Xuat() //ghi de ham Xuat cua class Person
        {
            //Console.WriteLine("Ten: " + ten + "\tTuoi: " + tuoi + "\tLop: " + lop);
            //hoac la
            base.Xuat();
            Console.WriteLine("Lop: " + lop);
        }
        
    }
}