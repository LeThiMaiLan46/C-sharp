using System;

namespace buoi2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // thuc hanh enum
            Thu a = Thu.Thu5;
            int b = (int) a + 2;
            Console.WriteLine(a);
            Console.WriteLine((int) a);
            Console.WriteLine(b);
            Console.WriteLine((Thu) b);
            switch (a)
            {
                case Thu.Thu5 :
                    Console.WriteLine("ngay nghi");
                    break;
                default:
                    Console.WriteLine("khong la ngay nghi");
                    break;
            }
        }

        enum Thu
        {
            Thu2, // a=0
            Thu3,
            Thu4,
            Thu5,
            Thu6,
            Thu7,
            Chunhat
        }
    }
}