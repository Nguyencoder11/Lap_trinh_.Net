using System;

namespace NhapLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.WriteLine("========== HAY CHON 1 LUA CHON ==========");
                Console.WriteLine("|1. Kiem tra so nhap vao theo 'while'   |");
                Console.WriteLine("|2. Kiem tra so nhap vao theo 'do'      |");
                Console.WriteLine("=========================================");
                Console.Write("Nhap vao lua chon: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("n = ");
                        n = int.Parse(Console.ReadLine());
                        while (n < 1 || n > 100)
                        {
                            Console.WriteLine("Yeu cau nhap n>=1 va n<=100.");
                            Console.Write("n = ");
                            n = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        do
                        {
                            Console.Write("n = ");
                            n = int.Parse(Console.ReadLine());
                        } while (n < 1 || n > 100);
                        break;
                    default:
                        Console.WriteLine("Out of choice!");
                        break;
                }
            }
            catch(FormatException ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
