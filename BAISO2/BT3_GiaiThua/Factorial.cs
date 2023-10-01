using System;

namespace BT3_GiaiThua
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Yeu cau nhap so nguyen duong");

                }
            } while (n < 0);

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", n, factorial);
        }
    }
}
