using System;

namespace LeLenhNguyen_2021604114_proj52
{
    class GiaiPTB2
    {
        private int a, b, c;

        public GiaiPTB2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void GiaiPT()
        {
            double delta = b * b - 4 * a * c;   
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if(delta == 0)
            {
                Console.WriteLine($"Phuong trinh co nghiem kep x = {(double)-b/(2*a)}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
            }
        }
    } 
}