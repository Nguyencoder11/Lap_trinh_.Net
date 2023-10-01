using System;
using System.Collections.Generic;

namespace BT6_DanhSach
{
    internal class DanhSach
    {
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }

        static bool isOdd(int n) {
            return n % 2 != 0;
        }

        static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for(int i=2; i<=Math.Sqrt(n); i++) {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            List<int> numbers = new List<int>();
            do
            {
                Console.Write("Nhap so phan tu cua danh sach: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.Write("Cac so chan trong danh sach: ");
            foreach (int i in numbers)
            {
                if (isEven(i))
                {
                    Console.Write(i+" ");
                }
            }

            Console.Write("\nCac so le trong danh sach: ");
            foreach (int i in numbers)
            {
                if (isOdd(i))
                {
                    Console.Write(i+" ");
                }
            }

            Console.Write("\nCac so nguyen to trong danh sach: ");
            foreach(int i in numbers)
            {
                if (isPrime(i)) { 
                    Console.Write(i+" ");
                }
            }
        }
    }
}
