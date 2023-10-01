using System;

namespace BAI2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            double length, width;
            do
            {
                Console.Write("Nhap chieu dai: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                width = double.Parse(Console.ReadLine());
            } while(length<=0 || width<=0 || length<=width);

            Console.WriteLine("Chu vi: {0:0.00} \nDien tich: {1:0.00}", (length + width) * 2, (length * width));
        }
    }
}
