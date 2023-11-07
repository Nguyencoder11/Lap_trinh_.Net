using System;

namespace Bai1
{
    internal class Program
    {
        private delegate string DiemChuTongKet(double diem);
        static void Main(string[] args)
        {
            double diemTk;
            DiemChuTongKet diemChu = XacDinhDiemChu;

            Console.Write("Nhap ho ten sinh vien: ");
            string name = Console.ReadLine();
            try
            {
                Console.Write("Nhap diem tong ket: ");
                diemTk = double.Parse(Console.ReadLine());
                Console.WriteLine($"Sinh vien: {name}");
                Console.WriteLine("Diem tong ket: " + diemTk);
                Console.WriteLine("Diem chu: " + diemChu(diemTk));
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi dinh dang kieu du lieu");
            }
        }

        private static string XacDinhDiemChu(double diem)
        {
            if(diem < 4.0)
            {
                return "F";
            }
            else if(diem >= 4.0 && diem < 5.5)
            {
                return "D";
            }
            else if(diem >= 5.5 && diem < 7.0)
            {
                return "C";
            }
            else if(diem >= 7.0 && diem < 8.5)
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
