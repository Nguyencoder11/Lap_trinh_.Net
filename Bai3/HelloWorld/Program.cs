using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hay nhap vao 2 so.");
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());

                Console.Write($"{a} + {b} = {a + b}");
            }
            catch (FormatException ex)
            {
                Console.Write("Loi dinh dang DL: " + ex.Message);
            }
        }
    }
}
