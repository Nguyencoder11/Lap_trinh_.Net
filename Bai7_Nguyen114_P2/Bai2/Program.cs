using System;

namespace Bai2
{
    internal class Program
    {
        private delegate string delegateDiemChu(double diemtb);
        static void Main(string[] args)
        {
            double diemTk;
            // Su dung uy quyen multicast de goi ca 2 phuong thuc da viet 
            // xep loai hoc luc va diem chu cua sinh vien da nhap
            delegateDiemChu hocluc = XacDinhHocLuc;
            delegateDiemChu diemchu = XacDinhDiemChu;
            delegateDiemChu dsUyQuyen;
            dsUyQuyen = hocluc + diemchu;

            Console.Write("Nhap ho ten sinh vien: ");
            string name = Console.ReadLine();
            try
            {
                Console.Write("Nhap diem tong ket: ");
                diemTk = double.Parse(Console.ReadLine());
                Console.WriteLine("Sinh vien: " + name);
                Console.WriteLine("Diem tong ket: " + diemTk);
                Console.WriteLine("Hoc luc: " + hocluc(diemTk));
                Console.WriteLine("Diem chu: " + dsUyQuyen(diemTk));
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi dinh dang kieu du lieu");
            }
        }

        private static string XacDinhHocLuc(double diem)
        {
            if (diem >= 8.0)
            {
                return "Gioi";
            }
            else if (diem >= 6.5 && diem < 8.0)
            {
                return "Kha";
            }
            else if (diem >= 5.0 && diem < 6.5)
            {
                return "Trung binh";
            }
            else if (diem >= 3.5 && diem < 5.0)
            {
                return "Yeu";
            }
            else
            {
                return "Kem";
            }
        }
        private static string XacDinhDiemChu(double diem)
        {
            if (diem < 4.0)
            {
                return "F";
            }
            else if (diem >= 4.0 && diem < 5.5)
            {
                return "D";
            }
            else if (diem >= 5.5 && diem < 7.0)
            {
                return "C";
            }
            else if (diem >= 7.0 && diem < 8.5)
            {
                return "B";
            }
            else
            {
                return "A";
            }
        }
    }
}
