using System;

namespace BTH2_Class_Bai2
{
    class Program
    {
        class PhanSo
        {
            int tuso;
            public int Tuso { get { return tuso; } }
            int mauso;
            public int Mauso { get { return mauso; } }

            public void input()
            {
                Console.Write("Nhap tu so: ");
                tuso = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so: ");
                mauso = int.Parse(Console.ReadLine());
            }
            public void output()
            {
                if (mauso == 1)
                {
                    Console.WriteLine(tuso);
                }
                else
                {
                    Console.WriteLine("{0}/{1}", tuso, mauso);
                }
            }
            public static PhanSo PhanSo_toigian(int Tu, int Mau)
            {
                int num1 = Tu, num2 = Mau;
                int Remainder;
                while (num2 != 0)
                {
                    Remainder = num1 % num2;
                    num1 = num2;                //Tim GCD
                    num2 = Remainder;
                }
                int GCD = num1;
                PhanSo kqrg = new PhanSo();
                kqrg.tuso = Tu / GCD;
                kqrg.mauso = Mau / GCD;
                return kqrg;
            }

            public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
            {
                PhanSo ps3 = new PhanSo
                {
                    tuso = ps2.tuso * ps1.mauso + ps1.tuso * ps2.tuso,
                    mauso = ps2.mauso * ps1.mauso
                };
                return PhanSo_toigian(ps3.tuso, ps3.mauso);
                //PhanSo_toigian(ps3.tuso, ps3.mauso);

            }
            public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
            {
                PhanSo ps3 = new PhanSo
                {
                    tuso = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso,
                    mauso = ps2.mauso * ps1.mauso
                };
                return PhanSo_toigian(ps3.tuso, ps3.mauso);

            }
            public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
            {
                PhanSo ps3 = new PhanSo
                {
                    tuso = ps1.tuso * ps2.tuso,
                    mauso = ps2.mauso * ps1.mauso
                };
                return PhanSo_toigian(ps3.tuso, ps3.mauso);

            }
            public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
            {
                PhanSo ps3 = new PhanSo
                {
                    tuso = ps2.mauso * ps1.tuso,
                    mauso = ps2.tuso * ps1.mauso
                };
                return PhanSo_toigian(ps3.tuso, ps3.mauso);

            }
        }
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            ps1.input();
            PhanSo ps2 = new PhanSo();
            ps2.input();
            (ps1 + ps2).output();
            (ps1 - ps2).output();
            (ps1 * ps2).output();
            (ps1 / ps2).output();
        }
    }
}
