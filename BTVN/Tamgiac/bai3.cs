using System;

namespace Tamgiac
{
    internal class bai3
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhap vao cac canh cua tam giac
            Console.Write("Cạnh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Cạnh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cạnh c: ");
            c = Convert.ToDouble(Console.ReadLine());

            // Kiem tra dieu kien thoa man tam giac
            // neu sai thi yeu cau nhap lai
            while (a + b <= c || a + c <= b || b + c <= a || a <= 0 || b <= 0 || c <= 0)
            {
                Console.Write("Nhập lại 3 cạnh của tam giác thỏa mãn!!!\n");
                Console.Write("Cạnh a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Cạnh b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Cạnh c: ");
                c = Convert.ToDouble(Console.ReadLine());
            }

            // In ra ket qua chu vi va dien tich tam giac
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Chu vi tam giác: " + (a+b+c));
            Console.WriteLine("Diện tích tam giác: {0}", S);
        }   
    }
}
