using System;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ten nhan vien: ");
            string tenNhanVien = Console.ReadLine();
            Console.WriteLine("Nhap vao so tien ban hang: ");
            double soTienBanHang = double.Parse(Console.ReadLine());

            Action<string, double> tinhHoaHongDelegate = (ten, tienBanHang) =>
            {
                double hoaHong = 0;
                if (tienBanHang < 1000)
                {
                    hoaHong = 0;
                }
                else if (tienBanHang >= 1000 && tienBanHang <= 3000)
                {
                    hoaHong = tienBanHang * 0.05;
                }
                else if (tienBanHang > 3000)
                {
                    hoaHong = tienBanHang * 0.1;
                }

                Console.WriteLine("Nhan vien: " + ten);
                Console.WriteLine("So tien ban hang: " + tienBanHang);
                Console.WriteLine("So tien hoa hong: " + hoaHong);
            };

            tinhHoaHongDelegate(tenNhanVien, soTienBanHang);
        }
    }
}
