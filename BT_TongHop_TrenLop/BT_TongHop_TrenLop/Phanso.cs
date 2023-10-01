using System;

namespace BT_TongHop_TrenLop
{
    internal class Phanso
    {
        static int UCLN(int a, int b){
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        static void Main(string[] args)
        {
            int m, n;
            Console.Write("Nhap m = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());

            // Tim UCLN cua m va n sau do lay ca tu va mau chia cho UCLN do => phan so toi gian
            if (n == 0){
                Console.WriteLine("n phai khac 0");
                do
                {
                    Console.Write("Nhap n = ");
                    n = Convert.ToInt32(Console.ReadLine());
                }while (n == 0);
            } 
            int uc = UCLN(m, n);
            // input: 4/6 => output: 2/3
            Console.WriteLine("Phan so rut gon cua {0}/{1} la {2}/{3}", m, n, (m/uc), (n/uc));
        }
    }
}
