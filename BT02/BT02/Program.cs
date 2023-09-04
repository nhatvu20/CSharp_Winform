using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Program
    {
        public static void menu()
        {
            Console.WriteLine("**Tro choi tinh nhanh**");
            Console.WriteLine("**  +: tinh phep cong**");
            Console.WriteLine("**  -: tinh phep tru**");
            Console.WriteLine("**  *: tinh phep nhanh**");
            Console.WriteLine("**  /: tinh phep chia**");
        }

        public static void xuat(int a,char tt,int b)
        {
            switch (tt)
            {
                case '+':
                    Console.WriteLine("a + b = "+(a + b));
                    break;
                case '-':
                    Console.WriteLine("a - b = "+(a - b));
                    break;
                case '*':
                    Console.WriteLine("a * b = "+(a * b));
                    break;
                case '/':
                    Console.WriteLine("a / b = " + (a / b));
                    break;
                default:
                    Console.WriteLine("nhap sai vui long nhap lai");
                    break;
            }

        }
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("tt = ");
                char tt = char.Parse(Console.ReadLine());
                xuat(a, tt, b);
                Console.Write("ban co muon lam nua khong? y/n ");
                char check = char.Parse(Console.ReadLine());
                if(check=='n')
                {
                    break;
                }
            };

        }
    }
}
