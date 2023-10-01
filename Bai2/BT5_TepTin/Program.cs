using System;
using System.IO;

namespace BT5_TepTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lay du lieu tu file va doc file
            string file = @"F:\HaUI_Learn\Semester 5\Lap_trinh_.Net\matrix.txt";
            StreamReader sr = new StreamReader(file);

            // Lay cac gia tri cot va dong tu file
            int numRows = int.Parse(sr.ReadLine());
            int numCols = int.Parse(sr.ReadLine());

            // Lay gia tri ma tran trong file
            int[,] matrix = new int[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                string[] values = sr.ReadLine().Split(' ');
                for (int j = 0; j < numCols; j++)
                {
                    matrix[i,j] = int.Parse(values[j]);
                }
            }
            sr.Close();

            // Tinh tong phan tu ma tran va dua vao cuoi file
            int sum = 0;
            for (int i = 0;i < numRows; i++)
            {
                for (int j = 0;j < numCols; j++)
                {
                    sum += matrix[i,j];
                }
            }
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine($"Tong cac phan tu cua ma tran: {sum}");
            writer.Close();
            // Hien thi thong bao
            Console.WriteLine("Đã ghi vào file thành công");
        }
    }
}
