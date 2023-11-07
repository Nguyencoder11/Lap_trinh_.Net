using System;

namespace Bai3
{
    internal class Program
    {
        static void TinhHoaHong(string tennv, double soTienBanhang)
        {
            double hoaHong = 0;
            if(soTienBanhang < 1000)
            {
                hoaHong = 0;
            }
            else if(soTienBanhang >= 1000 && soTienBanhang <= 3000)
            {
                hoaHong = soTienBanhang * 0.05;
            }
            else if(soTienBanhang > 3000)
            {
                hoaHong = soTienBanhang * 0.1;
            }

            Console.WriteLine("Nhan vien: " + tennv);
            Console.WriteLine("So tien ban hang: " + soTienBanhang);
            Console.WriteLine("So tien hoa hong: " + hoaHong);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ten nhan vien: ");
            string tenNhanVien = Console.ReadLine();
            Console.WriteLine("Nhap vao so tien ban hang: ");
            double soTienBanHang = double.Parse(Console.ReadLine());

            // Su dung bien uy quyen Action de goi phuong thuc TinhHoaHong
            Action<string, double> tinhHoaHongDelegate = TinhHoaHong;

            tinhHoaHongDelegate(tenNhanVien, soTienBanHang);
        }
    }
}
