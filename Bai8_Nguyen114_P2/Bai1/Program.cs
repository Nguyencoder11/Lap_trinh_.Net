using System;

namespace Bai1
{
    internal class Program
    {
        delegate double PhepTinh(double x,double y);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Chon phep tinh:");
                Console.WriteLine("1. Tong");
                Console.WriteLine("2. Hieu");
                Console.WriteLine("3. Tich");
                Console.WriteLine("4. Thuong");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap lua chon cua ban: ");
                string choice = Console.ReadLine();

                Console.Write("Nhap so thu nhat: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Nhap so thu hai: ");
                double secondNumber = double.Parse(Console.ReadLine());

                PhepTinh phepTinh = null;

                switch (choice)
                {
                    case "1":
                        phepTinh = TingTong;
                        break;
                    case "2":
                        phepTinh = TinhHieu;
                        break;
                    case "3":
                        phepTinh = TinhTich;
                        break;
                    case "4":
                        phepTinh = TinhThuong;
                        break;
                    case "5":
                        Console.WriteLine("Da thoat chuong trinh");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong phu hop!!!");
                        break;
                }

                if(phepTinh != null)
                {
                    double result = phepTinh(firstNumber, secondNumber);
                    Console.WriteLine("Ket qua: " + result);
                }
            }
        }

        static double TingTong(double a, double b)
        {
            return a + b;
        }

        static double TinhHieu(double a, double b)
        {
            return a - b;
        }

        static double TinhTich(double a, double b)
        {
            return a * b;
        }

        static double TinhThuong(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0.");
                return 0;
            }
        }
    }
}
