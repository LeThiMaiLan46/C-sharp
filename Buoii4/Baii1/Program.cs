namespace Baii1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Sung sungtruong = new SungTruong("AK47", 4, 30, true);
            sungtruong.Ban();
            //ep kieu sung truong
            ((SungTruong)sungtruong).Ngam();
            Sung sungngan = new SungNgan("Beretta 92", 1, soDan: 6);
            sungngan.Ban();

        }
    }
}