using System;

namespace BAI8
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);


            for (int i = 1; i <= n; i++) 
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
