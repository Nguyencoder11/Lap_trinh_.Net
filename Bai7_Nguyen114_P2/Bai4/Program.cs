using System;

namespace Bai4
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
                double thue = ThueThuNhap(name, income);
                Console.WriteLine("Thue thu nhap cua " + name + " la: " + thue);
            };            
            ThuNhapTT(ten, tntt);
        }

        private static int ThueThuNhap(string ten, int tntt)
        {
            if (tntt <= 5000000)
            {
                return (int)(tntt * 0.05);
            }
            else if (tntt > 5000000 && tntt <= 10000000)
            {
                return (int)(tntt * 0.1 - 250000);
            }
            else
            {
                return (int)(tntt * 0.2 - 750000);
            }
        }
    }
}