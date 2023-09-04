using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        class Ps
        {
            int tu;
            int mau;
            public int Tu { get { return tu; }set { tu = value; } }
            public int Mau { get { return mau; }set { mau = value; } }
            public void nhap()
            {
                Console.Write("Tu: ");
                tu = int.Parse(Console.ReadLine());
                Console.Write("Mau: ");
                mau = int.Parse(Console.ReadLine());
            }
            public void xuat()
            {
                if (mau == 1)
                {
                    Console.WriteLine("{0}", tu);

                }
                else
                {
                    Console.WriteLine("{0}/{1}", tu, mau);
                }
            }
            public static Ps rutgon(int tu, int mau)
            {
                int Remainder;
                int num1 = tu;
                int num2 = mau;
                while (num2 != 0)
                {
                    Remainder = num1 % num2;
                    num1 = num2;                //Tim GCD
                    num2 = Remainder;
                }
                int GCD = num1;
                //Console.WriteLine("{0}/{1}", (num1 / GCD), (num2 / GCD));
                Ps kqtoigian = new Ps();
                kqtoigian.tu = tu / GCD;
                kqtoigian.mau = mau / GCD;
                return kqtoigian;
            }
            public static Ps operator +(Ps ps1,Ps ps2)
            {
                Ps kq = new Ps()
                {
                    tu = ps1.tu * ps2.mau + ps2.tu * ps1.mau,
                    mau = ps1.mau * ps2.mau
                };
                //rutgon(kq.tu, kq.mau);
                return rutgon(kq.tu, kq.mau);;
            }
            public static Ps operator -(Ps ps1, Ps ps2)
            {
                Ps kq = new Ps()
                {
                    tu = ps1.tu * ps2.mau - ps2.tu * ps1.mau,
                    mau = ps1.mau * ps2.mau
                };
                return rutgon(kq.tu, kq.mau);
                //rutgon(kq.tu, kq.mau);
            }
            public static Ps operator *(Ps ps1, Ps ps2)
            {
                Ps kq = new Ps()
                {
                    tu = ps1.tu*ps2.tu,
                    mau = ps1.mau * ps2.mau
                };
                return rutgon(kq.tu, kq.mau);
                //rutgon(kq.tu, kq.mau);
            }
            public static Ps operator /(Ps ps1, Ps ps2)
            {
                Ps kq = new Ps()
                {
                    tu = ps1.tu * ps2.mau,
                    mau = ps1.mau * ps2.tu
                };
                return rutgon(kq.tu, kq.mau);
                //rutgon(kq.tu, kq.mau);
            }
        }
        static void Main(string[] args)
        {
            Ps ps1 = new Ps();
            Ps ps2 = new Ps();
            Console.WriteLine("Nhap ps 1");
            ps1.nhap();
            Console.WriteLine("Nhap ps 2");
            ps2.nhap();
            Console.WriteLine("Cong: ");
            (ps1 + ps2).xuat();
            Console.WriteLine("Tru: ");
            (ps1 - ps2).xuat();
            Console.WriteLine("Nhan: ");
            (ps1 * ps2).xuat();
            Console.WriteLine("Chia: ");
            (ps1 / ps2).xuat();

        }
    }
}
