using System;

namespace ferrari
{
    abstract class hinhhoc          // lop truu tuong sinh ra de lam lop cha, để được kế thừa
    {
        public abstract double chuvi();     //==>> Đây chính là hàm ảo thuần túy 
        //phuong thuc truu tuong chac chan phai nam trong class truu tuong
        //nhung lop truu tuong khong can phai co phuong thuc truu tuong
    }
    class vehicles
    {
        private string phienban;
        public void setPhienban(string phienban)
        {
            this.phienban = phienban;
        }
        public string Phienban { get { return phienban; } set { phienban = value; } }   //property: thay the cho get, set
        protected int tocdotieuchuan;
        public vehicles()
        {
            tocdotieuchuan = 10;
        }

        public vehicles(int TocDo)
        {
            tocdotieuchuan = TocDo;
        }

        public virtual double maxspeed()
        {
            return 0;
        }

        public vehicles(vehicles x)
        {
            this.tocdotieuchuan = x.tocdotieuchuan;
        }
    }

    class ferarri : vehicles
    {
        private string mausac;
        private double hesotocdo;
        public ferarri():base()
        {
            mausac = "red";
            hesotocdo = 3.1;
        }
        public ferarri(int Tocdo, string Mausac, double Heso) : base(Tocdo) // Goi ham tao 1 tham so ben tren xuong
        {
            mausac = Mausac;
            hesotocdo = Heso;
        }

        public override double maxspeed()
        {
            return 1.0 * hesotocdo * tocdotieuchuan;
        }
        public void input()
        {
            Console.Write("Nhap toc do tieu chuan: ");
            tocdotieuchuan = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau sac: ");
            mausac = Console.ReadLine();
            Console.Write("Nhap toc do tieu chuan: ");
            hesotocdo = double.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Toc do tieu chuan: " + tocdotieuchuan);
            Console.WriteLine("Mau sac: " + mausac);
            Console.WriteLine("He so toc do: " + hesotocdo);
            Console.WriteLine("Toc do toi da: " + maxspeed());

        }
        public static bool operator > (ferarri f1, ferarri f2)
        {
            return f1.maxspeed() > f2.maxspeed();
        }
        public static bool operator < (ferarri f1, ferarri f2)
        {
            return f1.maxspeed() < f2.maxspeed();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //vehicles b = new vehicles();
            //Console.WriteLine(b.Phienban);
            //hinhhoc c = new hinhhoc();  ===> Không thể new lớp trừu tượng 
                //Cách giải quyết:
            //Lớp con thứ 2 cũng phải nằm trong lớp trừu tượng --> lớp con thứ 3 (tiếp theo) phải override 
            //Lớp con thứ 2 override lại 



            Console.Write("Nhap so doi tuong: ");
            int n = int.Parse(Console.ReadLine());
            ferarri[] a = new ferarri[n];
            Console.WriteLine("Nhap mang doi tuong: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap thon tin doi tuong thu {i + 1}");
                a[i] = new ferarri();
                a[i].input();
            }
            Console.WriteLine("THONG TIN VUA NHAP: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                a[i].output();
            }
            ferarri max = a[0];
            for (int i = 1; i < n; i++)
            {
                if(a[i]> max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("\nThong tin doi tuong co toc do toi da lon nhat trong DS la: ");
            max.output();
        }
    }
}

//nap chong va ghi de deu la tinh da hinh

//những lớp kế thừa lớp interface thì phải định nghĩa hết tất cả lớp đó.    Interface cũng chỉ dùng để kế thừa 
//Interface để xử lý đa kế thừa 

/*
interface I { }
interface I2 { }
class A: I, I2 { }
//1 class co the implement nhieu interface
//1 interface co the ke thua nhieu interface khac
*/