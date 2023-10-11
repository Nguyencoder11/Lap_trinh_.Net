using System;

namespace LeLenhNguyen_2021604114_proj52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai so 1
            Employee employee = new Employee("NV01", "Manh", 20, 6);
            employee.Input();
            employee.Output();
            Console.ReadLine();

            // Bai so 2
            Console.WriteLine("Nhap cac he so a, b, c cua phuong trinh bac 2:");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            GiaiPTB2 ptb2 = new GiaiPTB2(a, b, c);
            ptb2.GiaiPT();
            Console.ReadLine() ;

            // Bai so 3
            Console.Write("Nhap so luong doi tuong: ");
            int n = Convert.ToInt32(Console.ReadLine());

            TimUCLN[] doituongs = new TimUCLN[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Nhap so thu nhat cua doi tuong {i+1}: ");
                int sothu1 = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Nhap so thu hai cua doi tuong {i+1}: ");
                int sothu2 = Convert.ToInt32(Console.ReadLine());

                doituongs[i] = new TimUCLN(sothu1, sothu2);
            }

            Console.WriteLine("Danh sach cac doi tuong cung voi UCLN tuong ung:");
            for (int i = 0; i < n; i++)
            {
                int ucln = doituongs[i].UCLN();
                Console.WriteLine($"Doi tuong {i+1}: So thu nhat = {doituongs[i].SoThuNhat}, So thu 2 = {doituongs[i].SoThuHai}, UCLN = {ucln}");
            }
        }
    }
}
