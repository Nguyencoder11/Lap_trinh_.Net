using System;

namespace Bai1
{
    internal class Program
    {
        delegate int TinhTong(int a, int b);
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int sothu1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int sothu2 = int.Parse(Console.ReadLine());

            // Khoi tao bien uy quyen 
            TinhTong sum = TwoIntSum;
            
            Console.WriteLine("Tong 2 so la: " + sum(sothu1, sothu2));
        }

        static int TwoIntSum(int a, int b)
        {
            return a + b;
        }
    }
}
