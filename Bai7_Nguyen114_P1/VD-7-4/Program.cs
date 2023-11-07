using System;

namespace VD_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Su dung Func<>");
            // Khai bao uy quyen su dung Func<>
            Func<int, int, int> del1 = Cong2So;
            Console.WriteLine($"{a} + {b} = {del1(a, b)}");

            Console.WriteLine("Su dung Action<>");
            Console.Write("Nhap diem trung binh: ");
            double dtb = double.Parse(Console.ReadLine());
            // Khai bao uy quyen su dung Action<>
            Action<double> del2 = XepLoaiHocSinh;
            del2(dtb);
        }

        private static void XepLoaiHocSinh(double obj)
        {
            if(obj >= 8)
            {
                Console.WriteLine("\nHoc sinh dat loai: Gioi");
            }
            else if(obj >= 6.5)
            {
                Console.WriteLine("\nHoc sinh dat loai: Kha");
            }
            else if (obj >= 5)
            {
                Console.WriteLine("\nHoc sinh dat loai: Trung binh");
            }
            else if(obj >= 3.5)
            {
                Console.WriteLine("\nHoc sinh dat loai: Yeu");
            }
            else
            {
                Console.WriteLine("\nHoc sinh dat loai: Kem");
            }
        }

        private static int Cong2So(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}
