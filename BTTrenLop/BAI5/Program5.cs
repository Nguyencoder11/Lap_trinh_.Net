using System;
using System.Text;

namespace BAI5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào 1 số từ 1->7: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ hai");
                    break;
                case 3:
                    Console.WriteLine("Thứ ba");
                    break;
                case 4:
                    Console.WriteLine("Thứ tư");
                    break;
                case 5:
                    Console.WriteLine("Thứ năm");
                    break;
                case 6:
                    Console.WriteLine("Thứ sáu");
                    break;
                case 7:
                    Console.WriteLine("Thứ bảy");
                    break;
                default:
                    break;
            }
        }
    }
}
