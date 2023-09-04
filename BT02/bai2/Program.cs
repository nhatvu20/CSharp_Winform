using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        //public static int ngaytieptheo=0;
        //public static int thangtieptheo=0;
        //public static int namtieptheo=0;

        static void Main(string[] args)
        {
            Console.Write("Nhap ngay: ");
            int ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            bool check = false;
            int ngaytieptheo = ngay+1;
            int thangtieptheo = thang;
            int namtieptheo = nam;
            if (nam > 0)
            {
                if (thang > 0 && thang <= 12)
                {
                    if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                    {
                        if (ngay >= 1 && ngay <= 31)
                        {
                            check = true;
                            if (ngay == 31)
                            {
                                ngaytieptheo = 1;
                                if (thang == 12)    //Thang 12 phai sang nam moi
                                {
                                    thangtieptheo = 1;
                                    namtieptheo = nam + 1;
                                }
                                else
                                {   //Thang binh thuong chi can + 1
                                    thangtieptheo = thang + 1;
                                    namtieptheo = nam;
                                }
                            }
                        }
                    }
                    else if (thang == 2)
                    {
                        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                        {
                            if (ngay >= 1 && ngay <= 29)
                            {
                                check = true;
                                if (ngay == 29)
                                {
                                    ngaytieptheo = 1;
                                    thangtieptheo = thang + 1;
                                    namtieptheo = nam;
                                }
                            }
                        }else
                        {
                            if (ngay >= 1 && ngay <= 28)
                            {
                                check = true;
                                if (ngay == 28)
                                {
                                    ngaytieptheo = 1;
                                    thangtieptheo = thang + 1;
                                    namtieptheo = nam;
                                }
                            }
                        }
                    }
                    else
                    {
                        if(ngay>=1 && ngay <= 30)
                        {
                            check = true;
                            if (ngay == 30)
                            {
                                ngaytieptheo = 1;
                                thangtieptheo = thang + 1;
                                namtieptheo = nam;
                            }
                        }
                    }

                }
            }
            if (check == true)
            {
                Console.WriteLine("Ngay {0}/{1}/{2} hop le",ngay,thang,nam);
                //if (ngay!=28 && ngay != 29 && ngay != 30 && ngay != 31)
                //{
                //    ngaytieptheo = ngay + 1;
                //    thangtieptheo = thang;
                //    namtieptheo = nam;
                //}
                Console.WriteLine("Ngay tiep theo la {0}/{1}/{2}", ngaytieptheo, thangtieptheo, namtieptheo);
            }
            else
            {
                Console.WriteLine("Ngay {0}/{1}/{2} khong hop le", ngay, thang, nam);
            }
        }
    }
}
