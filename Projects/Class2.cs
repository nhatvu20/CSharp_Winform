using System;

public class Class1
{
	public Class1()
	{
        class baitap
        {
            static bool songuyen(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i*1 <= n; i++)
                {
                    if (n % i == 0) return false:
                }
                return true;
            }

            static bool sochinhphuong(int n)
            {
                int sprt = (int)Math.Sqrt(n);
                return sqrt * sqrt ==n;
            }

            static void Main(string[] args)
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhap phan tu thu {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            int tongsonguyen = 0, tongsochinhphuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (songuyen(arr[i]))
                {
                    tongsonguyen += arr[i]
                }
                if (sochinhphuong(arr[i]))
                {
                    tongsochinhphuong += arr[i]
                }
            }
            Console.WriteLine($"tong so nguyen to: {tongsonguyen}");
            Console.WriteLine($"tong so chinh phuong: {tongsochinhphuong}");
        }
	}
}
