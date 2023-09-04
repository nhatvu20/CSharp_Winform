using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double rong = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu Vi hinh chu nhat la " + (dai + rong) * 2);
            Console.WriteLine("Dien tich hinh chu nhat la: " + (dai * rong));
        }
    }
}
