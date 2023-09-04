using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static bool soNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool soCP(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
        static void Main(string[] args)
        {
            
            int n;
            int s = 0;
            int h = 0;
            Console.Write("Nhap so phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Cac phan tu mang la : ");
            foreach (int m in a)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
            Console.Write("Cac so nguyen to la: ");
            foreach (int num in a)
            {
                if (soNT(num))
                {
                    Console.Write("{0} ", num);
                }
            }

            Console.WriteLine();
            Console.Write("cac so chinh phuong la: ");
            foreach (int num in a)
            {
                if (soCP(num))
                {
                    Console.Write("{0} ", num);
                }
            }
            for (int i = 0; i < n; i++)
            {

                if (soNT(a[i]))
                    s += a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (soCP(a[i]))

                    h += a[i];
            }
            Console.WriteLine("Tong so nguyen to trong mang :" + s);
            Console.WriteLine("Tong so chinh phuong trong mang: " + h);
        }

    }
}