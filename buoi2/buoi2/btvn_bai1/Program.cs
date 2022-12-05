using System;

namespace btvn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DoKho doKho;
            ChoiTiep choiTiep;
            int soDoan;
            Random random = new Random();
            Exception chonDoKho;
            Exception chonChoiTiep;
            int chonDo = 0;
            int chonChoi = 0;
            do
            {
                Console.WriteLine("1. Do kho thap");
                Console.WriteLine("2. Do kho trung binh");
                Console.WriteLine("3. Do kho cao");
                //nhap do kho
                do
                {
                    try
                    {
                        chonDoKho = null;
                        Console.WriteLine("Nhap do kho");
                        chonDo = int.Parse(Console.ReadLine());
                        doKho = (DoKho) chonDo;
                    }
                    catch (Exception e)
                    {
                        chonDoKho = e;
                        Console.WriteLine("Nhap lai");
                        throw;
                    }
                } while (chonDoKho != null || chonDo < 1 || chonDo > 3);

                //choi
                switch (doKho)
                {
                    //do kho thap
                    case DoKho.DoKhothap:
                    {
                        Exception ex;
                        int soCanTim = random.Next(1, 10);
                        int k = 0;
                        for (int soLanChoi = 2; soLanChoi >= 0; soLanChoi--)
                        {
                            do
                            {
                                ex = null;
                                Console.WriteLine("Nhap vao mot so tu 1 den 10");
                                try
                                {
                                    soDoan = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    ex = e;
                                    Console.WriteLine(e);
                                    throw;
                                }
                            } while (ex != null);

                            if (soDoan < soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim lon hon!");
                                Console.WriteLine("Con " + (soLanChoi) + " lan nhap");
                            }

                            if (soDoan > soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim nho hon!");
                                Console.WriteLine("Con " + (soLanChoi) + " lan nhap");
                            }

                            if (soDoan == soCanTim)
                            {
                                k = 1;
                                Console.WriteLine("Dung. Chuc mung ban!");
                                break;
                            }
                        }

                        if (k == 0)

                        {
                            Console.WriteLine("Ban da thua. Cam on");
                        }
                        else
                        {
                            Console.WriteLine("Ban da thang. Cam on");
                        }

                        break;
                    }

                    // do kho trung binh
                    case DoKho.DoKhotrungbinh:
                    {
                        Exception ex;
                        int k = 0;
                        int soCanTim = random.Next(1, 100);
                        for (int soLanChoi = 7; soLanChoi >= 0; soLanChoi--)
                        {
                            do
                            {
                                ex = null;
                                Console.WriteLine("Nhap vao 1 so tu 1 den 100:");
                                try
                                {
                                    soDoan = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    ex = e;
                                    Console.WriteLine(e);
                                    throw;
                                }
                            } while (ex != null);

                            if (soDoan < soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim lon hon!");
                                Console.WriteLine("Ban con " + soLanChoi + " lan doan");
                            }

                            if (soDoan > soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim nho hon!");
                                Console.WriteLine("Ban con " + soLanChoi + " lan doan");
                            }

                            if (soDoan == soCanTim)
                            {
                                k = 1;
                                Console.WriteLine("Dung. Chuc mung ban!");
                                break;
                            }
                        }

                        if (k == 0)
                        {
                            Console.WriteLine("Ban da thua. Cam on");
                        }
                        else
                        {
                            Console.WriteLine("Ban da thang. Cam on");
                        }

                        break;
                    }

                    // do kho cao
                    case DoKho.DoKhocao:
                    {
                        Exception ex;
                        int k = 0;
                        int soCanTim = random.Next(1, 1000);
                        for (int soLanChoi = 11; soLanChoi >= 0; soLanChoi--)
                        {
                            do
                            {
                                ex = null;
                                Console.WriteLine("Nhap vao 1 so tu 1 den 1000:");
                                try
                                {
                                    soDoan = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    ex = e;
                                    Console.WriteLine(e);
                                    throw;
                                }
                            } while (ex != null);


                            if (soDoan < soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim lon hon!");
                                Console.WriteLine("Ban con " + soLanChoi + " lan doan");
                            }

                            if (soDoan > soCanTim)
                            {
                                Console.WriteLine("Sai. So can tim nho hon!");
                                Console.WriteLine("Ban con " + soLanChoi + " lan doan");
                            }

                            if (soDoan == soCanTim)
                            {
                                k = 1;
                                Console.WriteLine("Dung. Chuc mung ban!");
                                break;
                            }
                        }

                        if (k == 0)
                        {
                            Console.WriteLine("Ban da thua. Cam on");
                        }
                        else
                        {
                            Console.WriteLine("Ban da thang. Cam on");
                        }

                        break;
                    }
                }

                // chon choi tiep
                do
                {
                    chonChoiTiep = null;
                    Console.WriteLine("Ban co muon choi tiep ?");
                    Console.WriteLine("1. Co    0. Khong");
                    try
                    {
                        chonChoi = int.Parse(Console.ReadLine());
                        choiTiep = (ChoiTiep) chonChoi;
                    }
                    catch (Exception e)
                    {
                        chonChoiTiep = e;
                        Console.WriteLine(e);
                        throw;
                    }
                } while (chonChoiTiep != null || chonChoi < 0 || chonChoi > 1);
            } while (chonChoi == 1);

            Console.WriteLine("Cam on va chao tam biet!");
        }

        enum DoKho
        {
            DoKhothap = 1,
            DoKhotrungbinh = 2,
            DoKhocao = 3
        }

        enum ChoiTiep
        {
            Khong = 0,
            Co = 1
        }
    }
}