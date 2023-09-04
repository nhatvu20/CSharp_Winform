using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static bool checksnt(int n)
        {
            if (n < 2)
            {
                return false;
            }
             for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("nhap so tu nhien N = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            if (checksnt(n))
            {
                Console.WriteLine("{0} la so nguyen to", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so nguyen to", n);
            }
            //bool check = true;
            //if (n > 2)
            //{
            //    for (int i = 2; i < n / 2; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            check = false;
            //        }
            //    }
            //}
            //else if (n == 2)
            //{
            //    check = true;
            //}
            //else
            //{
            //    check = false;
            //}
            //if (check)
            //{
            //    Console.WriteLine("{0} la so nguyen to", n);
            //}
            //else
            //{
            //    Console.WriteLine("{0} khong la so nguyen to", n);
            //}
        }
    }
}
