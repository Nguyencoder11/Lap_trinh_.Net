using System;
using System.Collections.Generic;

namespace DeMinhHoaOOP
{
    class Program
    {
        private static List<KhachHang> DanhSachKhachHang = new List<KhachHang>();
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhập thông tin");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Tìm khách hàng");
                Console.WriteLine("4. Sắp xếp danh sách khách hàng");
                Console.WriteLine("5. Chèn khách hàng");
                Console.WriteLine("6. Xóa khách hàng");
                Console.WriteLine("7. Thoát");
                Console.Write("Vui lòng lựa chọn: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        NhapThongTin();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        TimKhachHang();
                        break;
                    case "4":
                        SapXepDanhSach();
                        break;
                    case "5":
                        ChenKhachHang();
                        break;
                    case "6":
                        XoaKhachHang();
                        break;
                    case "7":
                        Console.WriteLine("Đã thoát chương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lựa chọn từ Menu");
                        break;
                }
            }
        }

        private static void SapXepDanhSach()
        {
            DanhSachKhachHang.Sort((kh1, kh2) => kh1.TinhTongTien().CompareTo(kh2.TinhTongTien()));

            Console.WriteLine("Danh sách đã được sắp xếp theo tổng tiền tăng dần:");
            HienThiDanhSach();
        }

        private static void ChenKhachHang()
        {
            Console.Write("Nhập vị trí cần chèn (0 - " + DanhSachKhachHang.Count + "): ");
            int viTri = int.Parse(Console.ReadLine());

            if (viTri < 0 || viTri > DanhSachKhachHang.Count)
            {
                Console.WriteLine("Vị trí không hợp lệ.");
                return;
            }

            Console.WriteLine("Chọn loại khách hàng:");
            Console.WriteLine("1. Khách hàng thường");
            Console.WriteLine("2. Khách hàng VIP");
            Console.Write("Vui lòng chọn loại khách hàng: ");
            string loaiKhachHang = Console.ReadLine();

            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();

            if (KiemTraTrungMaKhachHang(maKhachHang))
            {
                Console.WriteLine("Mã khách hàng đã tồn tại.");
                return;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập số lượng mua: ");
            int soLuongMua = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            double donGia = double.Parse(Console.ReadLine());

            if (loaiKhachHang == "1")
            {
                KhachHang khachHang = new KhachHang(maKhachHang, hoTen, soLuongMua, donGia);
                DanhSachKhachHang.Insert(viTri, khachHang);
            }
            else if (loaiKhachHang == "2")
            {
                KhachHangVIP khachHangVip = new KhachHangVIP(maKhachHang, hoTen, soLuongMua, donGia);
                DanhSachKhachHang.Insert(viTri, khachHangVip);
            }

            Console.WriteLine("Đã chèn khách hàng thành công.");
        }

        private static void XoaKhachHang()
        {
            Console.Write("Nhập mã khách hàng cần xóa: ");
            string maKhachHang = Console.ReadLine();

            for (int i = 0; i < DanhSachKhachHang.Count; i++)
            {
                if (DanhSachKhachHang[i].MaKhachHang == maKhachHang)
                {
                    DanhSachKhachHang.RemoveAt(i);
                    Console.WriteLine("Đã xóa khách hàng có mã " + maKhachHang);
                    return;
                }
            }

            Console.WriteLine("Không tìm thấy khách hàng có mã " + maKhachHang);
        }

        private static void TimKhachHang()
        {
            int maxSoLuongMua = 0;
            List<KhachHang> khachHangs = new List<KhachHang>();
            foreach(KhachHang khachhang in DanhSachKhachHang)
            {
                if(khachhang.SoLuongMua > maxSoLuongMua)
                {
                    maxSoLuongMua = khachhang.SoLuongMua;
                    khachHangs.Clear();
                    khachHangs.Add(khachhang);
                }else if(khachhang.SoLuongMua == maxSoLuongMua){
                    khachHangs.Add(khachhang);
                }
            }

            Console.WriteLine("----- Khách hàng có số lượng mua hàng lớn nhất -----");
            foreach (KhachHang khachHang in khachHangs)
            {
                Console.WriteLine(khachHang.ToString());
            }
        }

        private static void HienThiDanhSach()
        {
            Console.WriteLine("Danh sách khách hàng:");
            Console.WriteLine("{0,12}{1,20}{2,15}{3,12}{4,12}{5,15}", "Mã KH", "Họ tên", "Số lượng mua", "Đơn giá", "Tổng tiền", "Quà tặng");
            foreach(KhachHang khachhang in DanhSachKhachHang)
            {
                Console.WriteLine(khachhang.ToString());
            }
        }

        private static void NhapThongTin()
        {
            Console.WriteLine("Chọn loại khách hàng:");
            Console.WriteLine("1. Khách hàng thường");
            Console.WriteLine("2. Khách hàng VIP");
            Console.Write("Vui lòng chọn loại khách hàng: ");
            string loaiKhachHang = Console.ReadLine();

            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();

            if (KiemTraTrungMaKhachHang(maKhachHang))
            {
                Console.WriteLine("Mã khách hàng đã tồn tại.");
                return;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập số lượng mua: ");
            int soLuongMua = int.Parse(Console.ReadLine()); 
            Console.Write("Nhập đơn giá: ");
            double donGia = double.Parse(Console.ReadLine());

            if(loaiKhachHang == "1")
            {
                KhachHang khachHang = new KhachHang(maKhachHang, hoTen, soLuongMua, donGia);
                DanhSachKhachHang.Add(khachHang);
            }
            else if(loaiKhachHang == "2")
            {
                KhachHangVIP khachHangVip = new KhachHangVIP(maKhachHang, hoTen, soLuongMua, donGia);
                DanhSachKhachHang.Add(khachHangVip);
            }

            Console.WriteLine("Đã nhập thông tin khách hàng thành công.");
        }

        private static bool KiemTraTrungMaKhachHang(string maKhachHang)
        {
            foreach(KhachHang khachhang in DanhSachKhachHang)
            {
                if(khachhang.MaKhachHang == maKhachHang)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
