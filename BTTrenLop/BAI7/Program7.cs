using System;

namespace BAI7
{
    internal class Program7
    {
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            if(n==2 || n==3) return true;
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if(n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.Write("Nhập n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            if (!isPrime(n))
            {
                Console.WriteLine("{0} không phải là số nguyên tố", n);
            } else
            {
                Console.WriteLine("{0} là số nguyên tố", n);
            }
        }
    }
}
