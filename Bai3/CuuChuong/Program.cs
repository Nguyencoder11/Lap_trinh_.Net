using System;

namespace CuuChuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== BANG CUU CHUONG ==========");
            /*
            int num = 2, so_nhan;
            do
            {
                so_nhan = 1;
                do
                {
                    Console.WriteLine($"{num} x {so_nhan} = {num * so_nhan}");
                }while (so_nhan++ <= 9);

                Console.WriteLine();
            } while (num++ <= 9);
            Console.ReadKey();
            */

            for (int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    int res = i * j;
                    Console.WriteLine($"{i} x {j} = {res}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
