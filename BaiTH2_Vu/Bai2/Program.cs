using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            string notify = n % 2 == 0 ? "So chan" : "So le";
            Console.WriteLine(notify);
        }
    }
}
