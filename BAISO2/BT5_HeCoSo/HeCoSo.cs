using System;

namespace BT5_HeCoSo
{
    internal class HeCoSo
    {
        // Ham chuyen doi tu co so 10 sang co so B
        static string ConvertFromDecimal(int n, int b)
        {
            string result = "";
            while (n > 0)
            {
                int conlai = n % b;
                result = conlai.ToString() + result;
                n = n / b;
            }

            return result;
        }

        // Ham chuyen tu co so B sang co so 10
        static int ConvertToDecimal(string n, int b)
        {
            int result = 0, power = 0;
            for (int i = n.Length - 1; i >= 0; i--)
            {
                int digit = getDigitValue(n[i]);
                if (digit < 0 || digit > b)
                {
                    Console.WriteLine("So N khong hop le trong he co so B.");
                    return -1;
                }
                result += digit * (int)Math.Pow(b, power);
                power++;
            }

            return result;
        }

        static int getDigitValue(char c)
        { 
            if(Char.IsDigit(c))
            {
                return (int)Char.GetNumericValue(c);
            }
            else
            {
                return (int)(Char.ToUpper(c)) - 55;
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                // Tao menu tuy chon
                Console.WriteLine("Chon mot tuy chon:");
                Console.WriteLine("1. Chuyen doi so nguyen N tu he co so 10 sang he co so B bat ky");
                Console.WriteLine("2. Chuyen doi so nguyen N tu he co so B bat ky sang he co so 10");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("So nguyen N (he co so 10): ");
                        int n = int.Parse(Console.ReadLine());

                        Console.Write("He co so B: ");
                        int b = int.Parse(Console.ReadLine());

                        string result1 = ConvertFromDecimal(n, b);
                        Console.WriteLine("Ket qua: " + result1);

                        break;
                    case 2:
                        Console.Write("So nguyen N (he co so B): ");
                        string n2 = Console.ReadLine();

                        Console.Write("He co so B: ");
                        int b2 = int.Parse(Console.ReadLine());

                        int result2 = ConvertToDecimal(n2, b2);
                        Console.WriteLine("Ket qua: " + result2);

                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le");
                        break;
                }
            }
        }
    }
}
