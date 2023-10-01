using System;

namespace BAI4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int bacLuong, ngayCong;
            long phuCap;
            Console.WriteLine("Nhap du lieu");
            Console.Write("Bac luong: ");
            bacLuong = int.Parse(Console.ReadLine());
            Console.Write("Ngay cong: ");
            ngayCong = int.Parse(Console.ReadLine());
            Console.Write("Phu cap: ");
            phuCap = long.Parse(Console.ReadLine());

            int NCTL;
            if(ngayCong < 25){
                NCTL = ngayCong;
            }
            else
            {
                NCTL = 25 + (ngayCong - 25) * 2;
            }

            long tienLinh = bacLuong * 1490000 * NCTL + phuCap;
            Console.WriteLine("Tien linh: " + tienLinh);
        }
    }
}
