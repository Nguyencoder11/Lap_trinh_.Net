using System;
using System.Collections.Generic;

namespace DanhSach
{
    internal class Program
    {
        static void printList(List<double> list)
        {
            foreach (double number in list)
            {
                Console.Write(number + " ");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // Tao danh sach va them du lieu
                List<double> list = new List<double>();
                list.Add(1.5);
                list.Add(0.75);
                list.Add(2.4);
                list.Add(-11.05);
                list.Add(-2.25);

                // In ra danh sach da sap xep
                list.Sort();
                Console.Write("Danh sach da sap xep: ");
                printList(list);

                // Xoa cac phan tu so am
                list.RemoveAll(number => number < 0);
                Console.Write("\nDanh sach da xoa so am: ");
                printList(list);

                // Nhap vao so x va chen vao danh sach
                Console.Write("\nNhap so x: ");
                double x = double.Parse(Console.ReadLine());
                int index = 0;
                while (index < list.Count && x > list[index])
                {
                    index++;
                }
                list.Insert(index, x);
                Console.Write("\nDanh sach sau khi chen: ");
                printList(list);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Loi dinh dang: " + e1.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Da xay ra loi: " + e.Message);
            }
        }
    }
}
