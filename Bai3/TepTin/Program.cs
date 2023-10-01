using System;
using System.IO;
using System.Linq;

namespace TepTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string oldFile = @"F:\HaUI_Learn\Semester 5\Lap_trinh_.Net\Bai3\TepTin\oldFile.txt";
            string newFile = @"F:\HaUI_Learn\Semester 5\Lap_trinh_.Net\Bai3\TepTin\newFile.txt";

            try
            {
                StreamReader src = new StreamReader(oldFile);
                StreamWriter copy = new StreamWriter(newFile);

                string text = src.ReadToEnd();
                if(string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("File khong co du lieu.");
                }
                else
                {
                    string newText = text.ToUpper();
                    copy.Write(newText);

                    Console.WriteLine("Ghi chuoi viet hoa vao file moi thanh cong");

                    string[] newWords = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    copy.WriteLine("\nSo tu: " + newWords.Length);
                    Console.WriteLine("Da ghi de so tu cua file thanh cong");
                    copy.Close();
                }
            }
            catch (FileNotFoundException ex1)
            {
                Console.Write("Loi khong tim thay file: " + ex1.FileName);
            }
            catch (IOException ex2)
            {
                Console.Write("Da xay ra mot ngoai le khi lam viec voi file: " + ex2.Message);
            }
        }
    }
}
