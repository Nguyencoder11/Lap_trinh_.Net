using System;

namespace XepLoaiHS
{
    internal class bai4
    {
        static void Main(string[] args)
        {
            // Nhap ten va diem so cua hoc sinh
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập tên học sinh: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập điểm: ");
            double score = double.Parse(Console.ReadLine());

            // Kiem tra dieu kien xep loai
            string flag;
            if (score >= 8) {
                flag = "Giỏi";
            } else if (score >= 6.5 && score < 8) {
                flag = "Khá";
            } else if (score >= 5 && score < 6.5) {
                flag = "Trung bình";
            } else {
                flag = "Yếu";
            }

            if(score < 0)
            {
                return;
            }

            // In ra cua so console
            Console.WriteLine("Họ tên học sinh: " + name.ToUpper());
            Console.WriteLine("Xếp loại: " + flag);
        }
    }
}
