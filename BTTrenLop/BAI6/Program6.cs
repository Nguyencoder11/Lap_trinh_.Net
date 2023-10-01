using System;

namespace BAI6
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do {
                Console.Write("Nhập số nguyên dương n để dừng CT: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            if (n > 0)
            {
                Console.WriteLine("Số nguyên dương đã được nhập. Dừng chương trình");
            }
        }
    }
}
