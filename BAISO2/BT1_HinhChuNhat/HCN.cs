using System;

namespace BT1_HinhChuNhat
{
    internal class HCN
    {
        static void Main(string[] args)
        {
            double cdai, crong;
            do
            {
                Console.Write("Nhap chieu dai: ");
                cdai = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                crong = double.Parse(Console.ReadLine());
            } while (cdai <= crong || cdai <= 0 || crong <= 0);

            Console.WriteLine("Chu vi hcn: {0:0.00}", (cdai + crong) * 2);
            Console.WriteLine("Dien tich hcn: {0:0.00}", (cdai * crong));
        }
    }
}
