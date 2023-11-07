using System;

namespace Bai5
{
    internal class Program
    {
        static int TinhHieu(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int sothu1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int sothu2 = int.Parse(Console.ReadLine());

            // Uy quyen Func<> de goi phuong thuc TinhHieu
            Func<int, int, int> tinhHieuDelegate = TinhHieu;
            Console.WriteLine("Hieu 2 so: " + tinhHieuDelegate(sothu1, sothu2));

            // Su dung bieu thuc lamda tinh hieu
            Func<int, int, int> tinhHieuDelegate2 = (x, y) => x - y;
            Console.WriteLine("Hieu cua 2 so: " + tinhHieuDelegate2(sothu1, sothu2));
        }
    }
}
