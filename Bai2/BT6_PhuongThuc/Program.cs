using System;
using System.Drawing;

namespace BT6_PhuongThuc
{
    internal class Program
    {
        static bool isPrime(int number)
        {
            if(number<2) return false;
            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int size;
            int[] arr;

            Console.Write("Nhap so luong phan tu: ");
            size = int.Parse(Console.ReadLine());
            arr = new int[size];

            Console.WriteLine("Nhap gia tri cac phan tu:");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Phan tu thu {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Cac phan tu so nguyen to trong mang: ");
            for (int i = 0; i < size; i++)
            {
                if (isPrime(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
