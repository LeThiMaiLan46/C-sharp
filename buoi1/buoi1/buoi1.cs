using System;
using System.Linq;

namespace buoi1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            string a;
            a = "fdsgdgfdgdf\t";
            Console.WriteLine(5+a); //in ra va xuong dong, 0 xuong dong dung
            */

            /*
            string b;
            b = Console.ReadLine(); //nhap vao
            Console.WriteLine(b);
            */

            /*
            int c;
            // c = int.Parse("5"); //in ra la 1 gia tri kieu int
            c = Convert.ToInt32("5"); //kieu khac
            Console.WriteLine(c);

            float a;
            a = float.Parse("5.33345");
            Console.WriteLine(a+6);
            */

            /*
            //toan hoc
            Console.WriteLine(Math.Pow((float)3/4, 2));
            */

            /*
            //Ham
            int a = 5;
            Console.WriteLine(Ham(ref a)); //tham chieu

            Ham(4, 5);

            int e;
            Console.WriteLine(Hamhai(out e));
            */

            /*
            //Mang
            int[] a = new[] {4, 5, 2, 6, 4};
            Mang(a);
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            
            foreach (var x in a)
            {
                Console.Write(x + " ");
            }
            */
            
            /*
            //Mang 2 chieu
            int[,] a;
            {
                {2,3,5}
                {4.2.7}
            };
            */
            string s ;
            s = Console.ReadLine();
            s=solution(s);
            Console.Write(s);
        }

        /// <summary>
        /// hàm trả về a+5
        /// </summary>
        /// <param name="a">doi so</param>
        /// <returns></returns>
        static int Ham(ref int a)
        {
            //ref: tham chieu
            a = a + 5;
            return a;
        }

        /// <summary>
        /// hàm trả về a, b
        static int Ham(int b, float c)
        {
            return b + 5;
        }
        
        static int Hamhai(out int e)
        {
            //out: khi khong khai bao e trong main
            e = 4 + 5;
            return e;
        }

        static void Mang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
            }
        }
        
        static string solution(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    s = s.Remove(i);
                }
                
            }
            return s;
        }

    }
}