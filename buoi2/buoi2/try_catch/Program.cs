using System;

namespace try_catch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //xu li ngoai le
            Exception ex;
            do
            {
                ex = null;
                try
                {
                    int a = int.Parse(Console.ReadLine());
                }
                catch (Exception e) //boi den xong ctrl rr de doi ten bien
                {
                    // neu ng dung nhap sai thi ex khac null
                    ex = e;
                    Console.WriteLine(e);
                }
                // quay lai vong lap tu dau cho ex = null
            } while (ex != null) ;
            Console.WriteLine("het chuong trinh");
        }
    }
}