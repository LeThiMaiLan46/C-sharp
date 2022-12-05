using System;

namespace Bai1
{
    public class Person
    {
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        protected string ten; //protected: chi cho Student truy cap
        protected int tuoi;

        public virtual void Xuat() //virtual: ghi de
        {
            Console.WriteLine("Ten: " + ten + "\tTuoi: " + tuoi);
        }
    }
}