using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        class sinhvien
        {
            public string masinhvien;
            public string hoten;
            public double diemtoan;
            public double diemly;
            public double diemhoa;
            public void nhap()
            {
                Console.Write("Nhap ma sinh vien: ");
                masinhvien = Console.ReadLine();
                Console.Write("Nhap ho ten sinh vien: ");
                hoten = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                diemtoan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                diemly = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                diemhoa = double.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                Console.WriteLine("ma sinh vien: "+masinhvien);
                Console.WriteLine("ho ten sinh vien: "+hoten);
                Console.WriteLine("Nhap diem toan: "+diemtoan);
                Console.WriteLine("Nhap diem hoa: "+diemhoa);
                Console.WriteLine("Nhap diem ly: "+diemly);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(13%5);
            //r=n-dxk --> Dung ket qua gan 0 hon
            //-13%5= -13-5x2=3
            //-13%5=-13-5x-3=2  --> -3 khong gan 0 = -2
            //13%-5=13-(-5)x-2=3
            Console.Write("Nhap so sinh vien = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cua cac sinh vien");
            sinhvien[] sv = new sinhvien[n];
            for(int i = 0; i < n; i++)
            {
                sv[i] = new sinhvien();
                Console.WriteLine("\nNhap sinh vien thu {0}:",i+1);
                sv[i].nhap();
            }
            Console.WriteLine("Thong tin cac sinh vien vua nhap la:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nsinh vien thu {0}:", i+1);
                sv[i].xuat();
            }

        }
    }
}
