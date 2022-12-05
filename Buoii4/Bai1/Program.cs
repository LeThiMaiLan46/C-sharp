namespace Bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student person = new Student();
            person.Ten = "Nguoi 1";
            person.Tuoi = 20;
            person.Lop = "KTPM";
            
            person.Xuat();
        }
    }
}