using System;

namespace structtt

{
internal class Program
    {
    public static void Main(string[] args)
        {
            Vector2 a;
            a.x = 5;
            a.y = 6;
            Console.WriteLine(a.DoDai());
        }
    }
    struct Vector2
    {
        public float x;
        public float y;
    
        public double DoDai()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}