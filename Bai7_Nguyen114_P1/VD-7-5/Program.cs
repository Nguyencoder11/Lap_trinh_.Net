using System;

namespace VD_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Su dung Func<> va phuong thuc vo danh");
            // Khai bao uy quyen dung Func<>
            Func<int, int, int> del1;
            // Khoi tao uy quyen dung phuong thuc vo danh
            del1 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("{0} + {1} = {2}", 2, 4, del1(2,4));

            Console.WriteLine("Su dung Action va bieu thuc lamda");
            // Khai bao uy quyen dung Action
            Action<double> del2;
            // Khoi tao uy quyen dung bieu thuc lamda
            del2 = (double diemTB) => 
            {
                if (diemTB >= 8)
                {
                    Console.WriteLine("\nHoc sinh dat loai: Gioi");
                }
                else if (diemTB >= 6.5)
                {
                    Console.WriteLine("\nHoc sinh dat loai: Kha");
                }
                else if (diemTB >= 5)
                {
                    Console.WriteLine("\nHoc sinh dat loai: Trung binh");
                }
                else if (diemTB >= 3.5)
                {
                    Console.WriteLine("\nHoc sinh dat loai: Yeu");
                }
                else
                {
                    Console.WriteLine("\nHoc sinh dat loai: Kem");
                }
            };
            del2(9);
        }
    }
}
