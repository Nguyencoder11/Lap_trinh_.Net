using System;

namespace VD_7_1
{
    internal class Program
    {
        delegate void HienThiThongBao(string thongBao);
        static void Main(string[] args)
        {
            HienThiThongBao hienThiThongBao = ThongBaoLoi;

            hienThiThongBao("Thieu ;");
        }

        static void ThongBaoLoi(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Chuong trinh cua ban co loi bien dich sau: " + message);

            Console.ResetColor();
        }
    }
}
