using System;

namespace CanBacHai
{
    internal class Canbac2
    {
        static void Main(string[] args)
        {
            double a, epsilon;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("a = ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("epsilon = ");
            epsilon = Convert.ToDouble(Console.ReadLine());

            double x0 = 1;
            double xn = x0;

            do
            {
                double xn1 = (a / xn + xn) / 2;
                if (Math.Abs(xn1 - xn) < epsilon)
                {
                    break;
                }
                xn = xn1;
            } while (true);

            Console.WriteLine("Căn bậc hai của {0} là: {1}", a, xn);
        }
    }
}
