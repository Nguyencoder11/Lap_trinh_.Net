using System;
using System.Collections.Generic;

namespace Bai2
{
    delegate void NhapVaHienThiDanhSachSinhVienDelegate(List<SinhVien> danhsach);

    class SinhVien
    {
        private string masinhvien;
        public string MaSinhVien
        {
            get { return masinhvien; }
            set { masinhvien = value; }
        }

        private string hoten;
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> danhsachSinhVien = new List<SinhVien>();
            NhapVaHienThiDanhSachSinhVienDelegate nhapDelegate = NhapDanhSachSinhVien;
            NhapVaHienThiDanhSachSinhVienDelegate hienthiDelegate = HienThiDanhSachSinhVien;

            // Use the combined delegate
            NhapVaHienThiDanhSachSinhVienDelegate nhapVaHienThiDelegate;
            nhapVaHienThiDelegate = nhapDelegate + hienthiDelegate;

            nhapVaHienThiDelegate(danhsachSinhVien);
        }

        static void HienThiDanhSachSinhVien(List<SinhVien> list)
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach(SinhVien sv in list)
            {
                Console.WriteLine("Ma sinh vien: {0}, Ho ten sinh vien: {1}", sv.MaSinhVien, sv.HoTen);
            }
        }

        static void NhapDanhSachSinhVien(List<SinhVien> list)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int soluong = int.Parse(Console.ReadLine());

            for(int i = 0; i < soluong; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.WriteLine("Nhap thong tin sinh vien thu {0}: ", i+1);
                Console.Write("Nhap ma sinh vien: ");
                sinhVien.MaSinhVien = Console.ReadLine();
                Console.Write("Nhap ho ten sinh vien: ");
                sinhVien.HoTen = Console.ReadLine();

                list.Add(sinhVien);
            }
        }
    }
}
