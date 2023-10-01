using System;

namespace BT4_TongHop23
{
    internal class TongHop
    {
        // Fibonacci de quy 
        static int fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        // Giai thua de quy
        static int factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * factorial(n - 1);
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
                Console.Write(fibonacci(i) + " ");
            }
            Console.Write("\n");
            Console.WriteLine("{0}! = {1}", n, factorial(n));
        }
    }
}
