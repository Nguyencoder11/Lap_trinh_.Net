using System;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, tong=0;
            try
            {
                Console.Write("Nhap so luong phan tu: ");
                size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"a[{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        tong += arr[i];
                    }
                }
                Console.WriteLine("Tong cac phan tu le trong mang: {0}", tong);
            }
            catch (FormatException e1)
            {
                Console.Write("Loi dinh dang: " + e1.Message);
            }
            catch (OverflowException e2) {
                Console.Write("Loi tran du lieu: " + e2.Message);
            }
        }
    }
}
