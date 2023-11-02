using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraTx1._5
{
    internal class Program
    {
        private static List<KhachHang> DanhSach = new List<KhachHang>();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1.Nhap");
                Console.WriteLine("2.HienThi");
                Console.WriteLine("3.Tim");
                Console.WriteLine("4.Thoat");
                Console.Write("Vui long lua chon :");
                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        Nhap();
                        break;
                        case "2":
                        HienThi();
                        break;
                        case "3":
                        Tim();
                        break;
                        case "4":
                        Console.WriteLine("Thoat chuong trinh");
                        return;
                    default:
                        Console.WriteLine("vui long chon lai");
                        break;
                }
            }
        }
        private static void Nhap() 
        {
            Console.WriteLine("Chon khach hang:");
            Console.WriteLine("1.thuong");
            Console.WriteLine("2.VIP");
            Console.Write("chon khach hang: ");
            string loaikhachhang = Console.ReadLine();

            Console.Write("ma khach hang :");
            string maKH = Console.ReadLine();
            if (kiemtra(maKH))
            {
                Console.WriteLine("ma khach hang da ton tai");
                return;
            }
            Console.WriteLine("ho ten: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("so luong mua : ");
            int slm = int.Parse(Console.ReadLine());
            Console.WriteLine("don gia :");
            double dg = double.Parse(Console.ReadLine());

            if(loaikhachhang == "1")
            {
                KhachHang khachhang = new KhachHang(maKH,hoTen,slm,dg);
                DanhSach.Add(khachhang);
            }
            else if(loaikhachhang == "2")
            {
                KhachHang khachhangvip = new KhachHang(maKH, hoTen, slm, dg);
                DanhSach.Add(khachhangvip);
            }
        }
        private static bool kiemtra(string maKH)
        {
            foreach(KhachHang khachhang in DanhSach)
            {
                if(khachhang.MaKhachHang == maKH)
                {
                    return true;
                }
            }
            return false;
        }
        private static void HienThi() 
        {
            Console.WriteLine("Danh sach khach hang");
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}","MKH","HT","SLM","DG","TT","QT");
            foreach(KhachHang khachhang in DanhSach)
            {
                Console.WriteLine(khachhang.ToString());
            }
        }
        private static void Tim() { }
    }
}
