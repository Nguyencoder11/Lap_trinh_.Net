using System;

namespace TinhToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Phep tinh can thuc hien: ");
                string pt = Console.ReadLine();

                switch (pt)
                {
                    case "+":
                        Console.Write($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.Write($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.Write($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        Console.Write($"{a} / {b} = {a / b}");
                        break;
                    default:
                        Console.WriteLine("Chi duoc nhap cac phep tinh: +, -, *, /");
                        break;
                }
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Loi dinh dang: " + e1.Message);
            }
        }
    }
}
