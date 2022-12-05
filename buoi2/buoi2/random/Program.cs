using System;

namespace random
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // tao ra mot nguoi de so ngau nhien co kieu du lieu la random
            Random randomm = new Random();
            randomm.Next(5,10); //tra ve so nguyen ngau nhien >= 5 va < 10
            double a = randomm.NextDouble(); //tra ve so ngau nhien >= 0.0 va < 1.0

        }
    }
}