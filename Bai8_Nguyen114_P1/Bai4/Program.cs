using System;

namespace Bai4
{
    internal class Program
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int sothu1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int sothu2 = int.Parse(Console.ReadLine());

            // Su dung bien uy quyen kieu Func<>
            Func<int, int, int> tongDelegate = TinhTong;

            Console.WriteLine("Tong cua 2 so la: " + tongDelegate(sothu1, sothu2));

            // Su dung phuong thuc vo danh khai bao bang delegate
            Func<int, int, int> tongDelegate2 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("Tong 2 so la: " + tongDelegate2(sothu1, sothu2));
        }
    }
}
