using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = "); 
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Pt vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Pt vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("{0}x + {1} = 0", a, b);
                Console.WriteLine("x = " + (-b / a));
            }      
        }
    }
}
