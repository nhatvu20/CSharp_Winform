using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class CONNGUOI
    {
        protected string hoten;
        protected int tuoi;
        protected string quequan;
        protected string gioitinh;
        public CONNGUOI()
        {
            hoten = "Nhat Vu";
            tuoi = 19;
            quequan = "Phuong Canh";
            gioitinh = "Nam";
        }
        public CONNGUOI(string hoten, int tuoi, string quequan, string gioitinhMoi)
        {
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.quequan = quequan;
            gioitinh = gioitinhMoi;
        }
        public virtual void nhap()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap ho tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
        }

        public virtual void xuat()
        {

        }

        class CANBO : CONNGUOI
        {
            private double hesoluong;
            private int thamniencongtac;
            public CANBO() : base()
            {
                hesoluong = 1.2;
                thamniencongtac = 10;
            }
            public CANBO(double heSo, int thamNien, string hoten, int tuoi, string quequan, string gioitinh) : base(hoten, tuoi, quequan, gioitinh)
            {
                hesoluong = heSo;
                thamniencongtac = thamNien;
            }
            public override void nhap()
            {
                Console.Write("Nhap ho ten: ");
                hoten = Console.ReadLine();
                Console.Write("Nhap ho tuoi: ");
                tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap que quan: ");
                quequan = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                gioitinh = Console.ReadLine();
                Console.Write("Nhap he so luong: ");
                hesoluong = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap he tham nien: ");
                thamniencongtac = int.Parse(Console.ReadLine());
            }
            public override void xuat()
            {
                Console.WriteLine(hoten + "\t" + tuoi + "\t" + quequan + "\t" + gioitinh + "\t\t" + hesoluong + "\t\t" + thamniencongtac);
            }
            public double tinhluong()
            {
                return hesoluong * 1300 + thamniencongtac * 100;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                CANBO[] a = new CANBO[3];
                Console.WriteLine("Nhap 3 doi tuong CAN BO:");
                a[0] = new CANBO(1, 10, "Nhat Vu", 19, "Ha Noi", "Nam");
                for (int i = 1; i < 3; i++)
                {
                    a[i] = new CANBO();
                    a[i].nhap();
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 1; j < 3; j++)
                    {
                        if (a[i].tinhluong() < a[j].tinhluong())
                        {
                            CANBO temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                Console.WriteLine("DS cac can bo theo chieu giam dan cua luong la:\n");
                Console.WriteLine("STT\tHoTen\tTuoi\tQueQuan\tGioiTinh\tHeSoLuong\tThamNienCongTac");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write((i + 1) + "\t");
                    a[i].xuat();
                }
                /*
                CANBO c1 = new CANBO(1, 10, "Nhat Vu", 19, "Ha Noi", "Nam");
                CANBO c2 = new CANBO();
                CANBO c3 = new CANBO();
                c2.nhap();
                c3.nhap();
                CANBO max = c1;
                CANBO min = c1;
                CANBO mid = c1;
                if (max.tinhluong() < c2.tinhluong())
                {
                    max = c2;
                }
                else
                {
                    min = c2;
                }
                if (min.tinhluong() > c3.tinhluong())
                {
                    min = c3;
                }
                if (max.tinhluong() < c3.tinhluong())
                {
                    max = c3;
                }
                if ((max == c1 && min == c3)||(max == c3 && min == c1))
                {
                    mid = c2;
                }
                else if ((max == c1 && min == c2)||(max == c2 && min == c1)) { mid = c3; }
                Console.WriteLine("DS cac can bo theo chieu giam dan cua luong la:\n");
                Console.WriteLine("STT" +"\t" + "hoten" + "\t" + "tuoi" + "\t" + "quequan" + "\t" + "gioitinh" + "\t" + "hesoluong" + "\t" + "thamniencongtac");
                Console.Write("1\t");
                max.xuat();
                Console.Write("2\t");
                mid.xuat();
                Console.Write("3\t");
                min.xuat();

                */
            }
        }
    }
}
