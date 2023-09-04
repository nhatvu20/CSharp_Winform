using System;

namespace Test1
{
    class PHO
    {
        int thit;
        int banhpho;
        int hanh;
        public PHO()
        {
            thit = 2;
            banhpho = 3;
            hanh = 1;
        }
        public PHO(int thit, int banhpho, int hanh)
        {
            this.thit = thit;
            this.banhpho = banhpho;
            this.hanh = hanh;
        }
        public int tinhtien()
        {
            return thit * 15000 + banhpho * 10000 + hanh * 2000;
        }
        public void input()
        {
            Console.Write("Luong thit = ");
            thit = int.Parse(Console.ReadLine());
            Console.Write("Luong banh pho = ");
            banhpho = int.Parse(Console.ReadLine());
            Console.Write("Luong hanh = ");
            hanh = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine(thit + "\t" + banhpho + "\t\t" + hanh + "\t" + tinhtien());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PHO[] p = new PHO[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nhap du lieu cho bat pho thu {0}:", i + 1);
                p[i] = new PHO();
                p[i].input();
            }
            Console.WriteLine("\nThong tin 10 bat pho vua nhap la:");
            Console.WriteLine("\nSTT\tThit\tBanh pho\tHanh\tThanh tien");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "\t");
                p[i].output();
            }
            int indexMax=0, indexMin=0;
            int max = p[0].tinhtien();
            for (int i = 1; i < 10; i++)
            {
                if (p[i].tinhtien() > max)
                {
                    indexMax = i;
                    max = p[i].tinhtien();
                }
            }
            int min = p[0].tinhtien();
            for (int i = 1; i < 10; i++)
            {
                if (p[i].tinhtien() < min)
                {
                    indexMin = i;
                    min = p[i].tinhtien();
                }
            }
            Console.WriteLine("Bat pho thu {0} co gia thap nhat la {1}", indexMin+1,min);
            Console.WriteLine("Bat pho thu {0} co gia cao nhat la {1}", indexMax+1, max);

        }
    }
}
