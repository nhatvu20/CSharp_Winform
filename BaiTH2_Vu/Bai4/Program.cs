using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static bool checksnt(uint n)
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
            uint n;
            Console.Write("N = ");
            n = Convert.ToUInt32(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i <= n; i++)
            {
                sum1 += i;
            }
            Console.WriteLine("Tong so tu nhien <=N la: " + sum1);
            Console.Write("N = ");
            n = Convert.ToUInt32(Console.ReadLine());
            int sum2 = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i%2==0)
                    sum2 += i;
            }
            Console.WriteLine("Tong so tu nhien chan <=N la: " + sum2);
            n = Convert.ToUInt32(Console.ReadLine());
            int sum3 = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                    sum3 += i;
            }
            Console.WriteLine("Tong so tu nhien le <=N la: " + sum3);
            n = Convert.ToUInt32(Console.ReadLine());
            int sum4 = 0;
            for (int i = 0; i <= n; i++)
            {
                if (checksnt(n))
                    sum3 += i;
            }
            Console.WriteLine("Tong so tu nhien le <=N la: " + sum4);
        }
    }
}
