using System;

namespace Bai2
{
    internal class Program
    {
        delegate double TinhHieu(double a, double b);
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            double sothu1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double sothu2 = double.Parse(Console.ReadLine());

            Func<double, double, double> hieu = Hieu2So;
            Console.WriteLine("Hieu 2 so la: " + hieu(sothu1, sothu2));
        }

        static double Hieu2So(double a, double b)
        {
            return a - b;
        }
    }
}
