using System;

namespace BT2_Fibonacci
{
    internal class fibonacci
    {
        static int Fibo(int n)
        {
            if (n <= 1) return n;
            int f = 0;
            int f1 = 0, f2 = 1;

            for (int i = 2; i <= n; i++)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n = ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Yeu cau nhap so nguyen duong");

                }
            } while (n < 0);

            Console.Write($"{n} so fibonacci dau tien la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i) + " ");
            }
        }
    }
}
