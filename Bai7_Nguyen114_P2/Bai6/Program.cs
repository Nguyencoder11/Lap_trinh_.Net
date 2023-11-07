using System;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten: ");
            string ten = Console.ReadLine();
            Console.Write("Thu nhap tinh thue: ");
            int tntt = int.Parse(Console.ReadLine());

            Action<string, int> ThuNhapTT = (name, income) =>
            {
                double thue = income <= 5000000
                    ? income * 0.05
                    : income <= 10000000
                    ? income * 0.1 - 250000
                    : income * 0.2 - 750000;

                Console.WriteLine("Thue thu nhap cua " + name + " la: " + thue);
            };
            ThuNhapTT(ten, tntt);
        }
    }
}
