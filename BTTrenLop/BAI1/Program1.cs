using System;

namespace BAI1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int n;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            n = int.Parse(Console.ReadLine());

            // Kiem tra chan le
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} là số chẵn", n);
            }
            else
            {
                Console.WriteLine("{0} là số lẻ", n);
            }

            // Kiem tra so am hoac khong am
            if (n < 0)
            {
                Console.WriteLine("{0} là số âm", n);
            } else if (n > 0)
            {
                Console.WriteLine("{0} là số không âm", n);
            } else
            {
                Console.WriteLine("{0} là không phải số âm cũng không là số không âm", n);
            }
        }
    }
}
