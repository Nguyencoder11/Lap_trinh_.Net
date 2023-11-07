using System;

namespace Bai3
{
    internal class Program
    {
        delegate double TienHoaHong(int sotien);
        static void Main(string[] args)
        {
            int sotienban;
            Func<int, double> hoahong = TinhTienHoaHong;

            Console.Write("Nhap ten nhan vien: ");
            string tenNV = Console.ReadLine();
            try
            {
                Console.Write("Nhap so tien ban hang: ");
                sotienban = int.Parse(Console.ReadLine());

                Console.WriteLine($"Nhan vien: {tenNV}");
                Console.WriteLine($"Tien ban hang: {sotienban}");
                Console.WriteLine($"Tien hoa hong: {hoahong(sotienban)}");

            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Loi dinh dang kieu du lieu");
                Console.ResetColor();
            }
        }

        private static double TinhTienHoaHong(int soTienBanHang)
        {
            if (soTienBanHang < 1000)
            {
                return 0;
            }
            else if(soTienBanHang >= 1000 && soTienBanHang < 3000)
            {
                return soTienBanHang * 0.05;
            }
            else
            {
                return soTienBanHang * 0.1;
            }
        }
    }
}
