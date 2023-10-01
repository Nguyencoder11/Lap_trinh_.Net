using System;
using System.IO;

namespace BT7_FileVaNgoaiLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\source\file.txt";
            string targetPath = @"d:\target\file.txt";

            try
            {
                // su dung lop file co san
                // copy file tu thu muc c:\source sand d:\target
                File.Copy(sourcePath, targetPath);

                // Su dung StreamReader vaf StreamWriter
                using (StreamReader readFile = new StreamReader(sourcePath))
                using (StreamWriter writeFile = new StreamWriter(targetPath))
                {
                    string line;
                    while ((line = readFile.ReadLine()) != null)
                    {
                        writeFile.WriteLine(line);
                    }
                }
                Console.WriteLine("File copied successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while copying the file: " + ex.Message);
            }
        }
    }
}
