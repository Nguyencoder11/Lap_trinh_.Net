using System;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Nhap 3 canh:");
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = int.Parse(Console.ReadLine());

                while(a<=0 || b<=0 || c<=0){
                    Console.WriteLine("3 canh phai >0. Yeu cau nhap lai 3 canh:");
                    Console.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    c = int.Parse(Console.ReadLine());
                }
                if(a+b<=c || b+c<=a || a+c<=b) {
                    Console.WriteLine("Day khong phai 3 canh cua tam giac.");
                }
                else
                {
                    Console.WriteLine("Day la 3 canh cua tam giac.");
                    double p = (double)(a + b + c) / 2;
                    Console.Write("Chu vi: " + (a + b + c));
                    Console.Write("\nDien tich: {0:0.000}",Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Loi dinh dang: " + ex.Message);
            }
        }
    }
}
