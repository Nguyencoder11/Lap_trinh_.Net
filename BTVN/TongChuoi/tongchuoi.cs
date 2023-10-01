using System;

namespace TongChuoi
{
    internal class tongchuoi
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.Write("Nhập vào số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            }while (n<=0);

            int s1=0; 
            double s2=0;
            for (int i = 1; i <= n; i++) {
                s1 += i;
                s2 += 1.0/i;
            }

            Console.WriteLine("Tổng s1 = " + s1);
            Console.WriteLine("Tổng s2 = " + s2);
        }
    }
}
