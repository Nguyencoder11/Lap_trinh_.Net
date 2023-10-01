using System;

namespace TachDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("Nhap cac phan tu:");
                for (int i = 0; i < size; i++) {
                    Console.Write($"arr[{i}] = ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int[] arrEven = new int[10];
                int[] arrOdd = new int[10];
                int j = 0, k = 0;

                for(int i = 0; i < size; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        arrEven[j++] = arr[i];
                    }
                    else
                    {
                        arrOdd[k++] = arr[i];
                    }
                }
                Console.Write("\nMang so chan: ");
                for(int i=0; i<j; i++)
                {
                    Console.Write(arrEven[i] + " ");
                }
                Console.Write("\nMang so le: ");
                for(int i=0; i<k; i++)
                {
                    Console.Write(arrOdd[i] + " ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Loi dinh dang du lieu: " + ex.Message);
            }
            catch (OverflowException ex1)
            {
                Console.WriteLine("Loi tran du lieu: " + ex1.Message);
            }
        }
    }
}
