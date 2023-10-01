using System;

namespace Chuoi
{
    internal class Program
    {
        static bool isPalindrome(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao chuoi: ");
                string myString = Console.ReadLine();   
                if (isPalindrome(myString))
                {
                    Console.Write("Day la chuoi doi xung");
                }
                else
                {
                    Console.Write("Day khong phai la chuoi doi xung");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
