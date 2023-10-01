using System;

namespace BAI3
{
    internal class Program3
    {
        static void PTB1(double a, double b) {
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("PTB1 co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("PTB1 vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("PTB1 co nghiem: x = " + (-b / a));
            }
        }

        static void PTB2(double a, double b, double c) { 
            if(a == 0)
            {
                PTB1(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("PTB2 co 2 nghiem phan biet");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
                else if(delta == 0)
                {
                    Console.WriteLine("PTB2 co nghiem kep x = " + -b/(2*a));
                }
                else
                {
                    Console.WriteLine("PTB2 vo nghiem");
                }
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Nhap cac he so: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            // Giai phuong trinh bac 1
            PTB1(a, b);
            // Giai phuong trinh bac 2
            PTB2(a, b, c);
            Console.ReadLine();
        }
    }
}
