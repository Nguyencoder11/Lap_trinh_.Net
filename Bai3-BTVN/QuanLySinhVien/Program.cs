using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace QuanLySinhVien
{
    struct Student
    {
        public int id;
        public string name;
        public string gender;
        public int age;
        public double mathScore;
        public double physicsScore;
        public double chemistryScore;
        public double averageScore;
        public string academicPerformance;
    }
    class Program
    {
        static void ReadListFromFile(string filename)
        {
            try
            {
                StreamReader readFile = new StreamReader(filename);
                readFile.ReadToEnd();
                if (!readFile.EndOfStream)
                {
                    string line = readFile.ReadLine();
                    string[] data = line.Split(',');
                    Student student = new Student();
                    student.id = int.Parse(data[0]);
                    student.name = data[1];
                    student.gender = data[2];
                    student.age = int.Parse(data[3]);
                    student.mathScore = double.Parse(data[4]);
                    student.physicsScore = double.Parse(data[5]);
                    student.chemistryScore = double.Parse(data[6]);
                    student.averageScore = double.Parse(data[7]);
                    student.academicPerformance = data[8];
                    students.Add(student);
                    currentID = Math.Max(currentID, student.id + 1);
                }
            }
            catch (FileNotFoundException){
                Console.WriteLine("Không tìm thấy file dữ liệu sinh viên");
            }
        }
        static void ShowMenu()
        {

        }

        static List<Student> students = new List<Student>();
        static int currentID = 1;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                string data = @"F:\HaUI_Learn\Semester 5\Lap_trinh_.Net\Bai3-BTVN\QuanLySinhVien\data.txt";
                ReadListFromFile(data);

                
                //ShowMenu();
            }
            catch (IOException io)
            {
                Console.WriteLine("Lỗi I/O: " + io.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Lỗi truy cập file: " + e.Message);
            }
        }

        
    }
}
