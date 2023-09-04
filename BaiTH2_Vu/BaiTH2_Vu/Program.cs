using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH2_Vu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kinh = ");
            double r = Convert.ToDouble(Console.ReadLine());
            const double pi = 3.14;
            Console.WriteLine("Chu vi hinh tron la: " + (2 * pi * r));
            Console.WriteLine("Dien tich hinh tron la: " + (pi * r * r));
        }
    }
}
