using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_Class_Bai5
{
    class CONNGUOI
    {
        protected string hoten;
        protected int tuoi;
        protected string quequan;
        protected string gioitinh;
        public CONNGUOI(){
            hoten = "Nguyen Gia Long";
            tuoi = 20;
            quequan = "QuangNinh";
            gioitinh = "Nam";
        }
        public CONNGUOI(string hoten, int tuoi, string quequan, string gioitinh)
        {
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.quequan = quequan;
            this.gioitinh = gioitinh;
        }
        public virtual void nhap()
        {
            /*Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine(); 
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();*/
        }
        public virtual void xuat()
        {

        }
    }
    class CANBO : CONNGUOI
    {
        double hesoluong;
        int thamniencongtac;
        public CANBO(): base()
        {
            hesoluong = 3.6;
            thamniencongtac = 7;
        }
        public CANBO(string hoten, int tuoi, string quequan, string gioitinh,double hesoluong,int thamniencongtac):base(hoten, tuoi, quequan, gioitinh)
        {
            this.hesoluong = hesoluong;
            this.thamniencongtac = thamniencongtac;
        }
        public override void nhap()
        {
            Console.Write("\nNhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            hesoluong = double.Parse(Console.ReadLine()); 
            Console.Write("Nhap tham nien cong tac: ");
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
    class SINHVIEN : CONNGUOI
    {
        float diemtoan;
        float diemly;
        float diemhoa;
        public SINHVIEN()
        {

        }
        public SINHVIEN(string hoten, int tuoi, string quequan, string gioitinh, float diemtoan,float diemly, float diemhoa):base(hoten, tuoi, quequan, gioitinh)
        {
            this.diemtoan = diemtoan;
            this.diemly = diemly;
            this.diemhoa = diemhoa;
        }
        public float tinhdiemTB()
        {
            return (diemhoa + diemly + diemtoan) / 3;
        }
        public override void xuat()
        {
            Console.WriteLine(hoten + "\t" + tuoi + "\t" + quequan + "\t" + gioitinh + "\t\t" + diemtoan + "\t" + diemly + "\t" + diemhoa + "\t" + tinhdiemTB());
        }
        public override void nhap()
        {
            Console.Write("\nNhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemtoan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            diemly = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemhoa = float.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Tao doi tuong can bo
            CANBO[] a = new CANBO[3];
            Console.WriteLine("Nhap 3 doi tuong CAN BO:");
            a[0] = new CANBO("Nhat Vu", 19, "Ha Noi", "Nam", 3, 5);
            for (int i = 1; i < 3; i++)
            {
                a[i] = new CANBO();
                a[i].nhap();
            }
            for(int i= 0; i < 2; i++)
            {
                for(int j=1;j<3; j++)
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
                Console.Write((i+1)+"\t");
                a[i].xuat();
            }

            //Tao doi tuong sinh vien
            SINHVIEN[] b = new SINHVIEN[5];
            Console.WriteLine("Nhap 5 doi tuong SINH VIEN:");
            b[0] = new SINHVIEN("Gia Long", 20, "Quang Ninh", "Nu", 8, 8,8);
            for (int i = 1; i < 5; i++)
            {
                b[i] = new SINHVIEN();
                b[i].nhap();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (b[i].tinhdiemTB() > b[j].tinhdiemTB())
                    {
                        SINHVIEN temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            Console.WriteLine("DS cac sinh vien theo chieu tang dan cua diem TB la:\n");
            Console.WriteLine("STT\tHoTen\tTuoi\tQueQuan\tGioiTinh\tDiemToan\tDiemLy\tDiemHoa\tDiemTB");
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "\t");
                b[i].xuat();
            }


            /*CANBO c1 = new CANBO("Nhat Vu",19,"Ha Noi","Nam",3,5);
            CANBO c2 = new CANBO();
            CANBO c3 = new CANBO();
            c2.nhap();
            c3.nhap();
            CANBO max = c1;
            CANBO min = c1;
            CANBO mid = c1;
            if(max.tinhluong() < c2.tinhluong())
            {
                max = c2;
            } else
            {
                min = c2;
            }
            if(min.tinhluong()> c3.tinhluong())
            {
                min = c3;
            }
            if (max.tinhluong()<c3.tinhluong())
            {
                max = c3;
            }
            if((max == c1&&min==c3)|| (max == c3 && min == c1))
            {
                mid = c2;
            }
            else if((max == c1 && min == c2) || (max == c2 && min == c1)) { mid = c3; }
            Console.WriteLine("DS cac can bo theo chieu giam dan cua luong la:\n");
            Console.WriteLine("STT\tHoTen\tTuoi\tQueQuan\tGioiTinh\tHeSoLuong\tThamNienCongTac");
            Console.Write("1\t");
            max.xuat();
            Console.Write("2\t");
            mid.xuat();
            Console.Write("3\t");
            min.xuat();*/
        }
    }
}
