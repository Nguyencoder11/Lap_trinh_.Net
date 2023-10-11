using System;
using System.Collections.Generic;

namespace LeLenhNguyen_2021604114_proj51
{
    internal class Program
    {
        static List<ThisinhA> danhsach = new List<ThisinhA>();

        static void Main(string[] args)
        {
            Console.WriteLine("MAIN MENU");
            while (true)
            {
                Console.WriteLine("\n1. Nhap thong tin 1 thi sinh");
                Console.WriteLine("2. Hien thi danh sach cac thi sinh");
                Console.WriteLine("3. Hien thi cac sinh vien theo tong diem");
                Console.WriteLine("4. Hien thi cac sinh vien theo dia chi");
                Console.WriteLine("5. Tim kiem theo so bao danh");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.Write("Nhap lua chon: ");
                string chose;
                chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        NhapThongTin1SinhVien();
                        break;
                    case "2":
                        Console.WriteLine("DANH SACH SINH VIEN");
                        HienThiThongTin();
                        break;
                    case "3":
                        HienThiSinhVienTheoTongDiem();
                        break;
                    case "4":
                        HienThiSinhVienTheoDiaChi();
                        break;
                    case "5":
                        TimKiemTheoSBD();
                        break;
                    case "6":
                        Console.WriteLine("Da thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long lua chon lai:");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void TimKiemTheoSBD()
        {
            Console.Write("Nhap so bao danh: ");
            string sbd = Console.ReadLine();

            foreach(ThisinhA thisinh in danhsach)
            {
                if(thisinh.SoBaoDanh == sbd)
                {
                    Console.WriteLine(thisinh.ToString());
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay thi sinh co so bao danh {sbd}");
        }

        private static void HienThiSinhVienTheoDiaChi()
        {
            Console.Write("Nhap dia chi: ");
            string diachi = Console.ReadLine();

            Console.WriteLine($"Danh sach thi sinh co dia chi '{diachi}':");
            foreach(ThisinhA thisinh  in danhsach)
            {
                if (thisinh.DiaChi.Contains(diachi))
                {
                    Console.WriteLine(thisinh.ToString());
                }
            }
        }

        private static void HienThiSinhVienTheoTongDiem()
        {
            Console.Write("Nhap tong diem: ");
            double tongdiem = double.Parse(Console.ReadLine());

            Console.WriteLine($"Danh sach thi sinh co diem tong >= {tongdiem}:");
            foreach(ThisinhA ts in danhsach)
            {
                if(ts.TongDiem >= tongdiem)
                {
                    Console.WriteLine(ts.ToString());
                }
            }
        }

        private static void HienThiThongTin()
        {
            Console.WriteLine("{0,12}{1,20}{2,15}{3,12}{4,12}{5,12}{6,15}{7,12}", "So bao danh", "Ho ten", "Dia chi", "Diem toan", "Diem ly", "Diem hoa", "Diem uu tien", "Tong diem");
            foreach(ThisinhA student in danhsach)
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void NhapThongTin1SinhVien()
        {
            Console.WriteLine("Nhap thong tin thi sinh:");
            Console.Write("So bao danh: ");
            string sbd = Console.ReadLine();
            Console.Write("Ho va ten: ");
            string hoten = Console.ReadLine();
            Console.Write("Dia chi: ");
            string diachi = Console.ReadLine();
            Console.Write("Diem toan: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Diem ly: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Diem hoa: ");
            double hoa = double.Parse(Console.ReadLine());
            Console.Write("Diem uu tien: ");
            double diemuutien = double.Parse(Console.ReadLine());

            ThisinhA thisinh = new ThisinhA(sbd, hoten, diachi, toan, ly, hoa, diemuutien);
            danhsach.Add(thisinh);

            Console.WriteLine("Them thong tin thi sinh thanh cong.");
        }
    }
}
