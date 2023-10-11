using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        // Khoi tao danh sach sinh vien
        static List<Student> students = new List<Student>();
        // Khoi tao ID hien tai
        //static int currentID = 1;
        // Ham doc du lieu tu file
        static bool ReadListFromFile(string filename)
        {
            try
            {
                StreamReader readFile = new StreamReader(filename);
                while (!readFile.EndOfStream)
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
                    //currentID = Math.Max(currentID, student.id + 1);
                }
                readFile.Close();
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy file dữ liệu.");
            }
            catch (IOException)
            {
                Console.WriteLine("Lỗi đọc file.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Định dạng file không hợp lệ.");
            }
            return false;
        }
        // Ham hien thi menu
        static void ShowMenu()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("|\t\t\tMENU\t\t\t\t|");
            Console.WriteLine("| 1. Thêm sinh viên                                     |");
            Console.WriteLine("| 2. Cập nhật thông tin sinh viên bởi ID                |");
            Console.WriteLine("| 3. Xóa sinh viên bởi ID                               |");
            Console.WriteLine("| 4. Tìm kiếm sinh viên theo tên                        |");
            Console.WriteLine("| 5. Sắp xếp sinh viên theo điểm trung bình             |");
            Console.WriteLine("| 6. Sắp xếp sinh viên theo tên                         |");
            Console.WriteLine("| 7. Hiển thị danh sách sinh viên                       |");
            Console.WriteLine("| 8. Ghi danh sách sinh viên vào file 'student.txt'     |");
            Console.WriteLine("| 0. Thoát                                              |");
            Console.WriteLine("*-------------------------------------------------------*");

        }
        
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lay du lieu tu file 'student.txt'
            string dataFile = @"F:\HaUI_Learn\Semester 5\Lap_trinh_.Net\Bai3-BTVN\QuanLySinhVien\student.txt";
            bool isFileReadSuccessful = ReadListFromFile(dataFile);
            if (isFileReadSuccessful)
            {
                ShowStudentList();
                int option;
                do
                {
                    ShowMenu();
                    Console.Write("Vui lòng nhập lựa chọn: ");
                    option = int.Parse(Console.ReadLine());
                    try
                    {
                        switch(option)
                        {
                            case 1:
                                AddStudent();
                                break;
                            case 2:
                                UpdateStudent();
                                break;
                            case 3:
                                DeleteStudent();
                                break;
                            case 4:
                                SearchStudentByName();
                                break;
                            case 5:
                                SortStudentsByAverageScore();
                                break;
                            case 6:
                                SortStudentsByName();
                                break;
                            case 7:
                                ShowStudentList();
                                break;
                            case 8:
                                SaveStudentsToFile(dataFile);
                                break;
                            case 0:
                                Console.WriteLine("Đã thoát chương trình.");
                                break;
                            default:
                                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                                break;
                        }
                        Console.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Đã xảy ra lỗi" + ex.Message);
                        Console.WriteLine();
                    }
                } while (option != 0);
            }
            else
            {
                Console.WriteLine("Không thể đọc dữ liệu từ file. Vui lòng kiểm tra lại.");
            }
        }

        // Ham them moi 1 sinh vien
        static void AddStudent()
        {
            Student student = new Student();
            Console.Write("Tên sinh viên: ");
            student.name = Console.ReadLine();
            Console.Write("Giới tính: ");
            student.gender = Console.ReadLine();
            Console.Write("Tuổi: ");
            student.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Điểm toán: ");
            student.mathScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Điểm lý: ");
            student.physicsScore = Convert.ToDouble(Console.ReadLine());
            Console.Write("Điểm hóa: ");
            student.chemistryScore = Convert.ToDouble(Console.ReadLine());

            student.id = GenerateStudentId();
            student.averageScore = CalculateAverageScore(student.mathScore, student.physicsScore, student.chemistryScore);
            student.academicPerformance = GetAcademicPerformance(student.averageScore);

            students.Add(student);
            Console.WriteLine("Thêm sinh viên thành công. ID của sinh viên mới: " + student.id);
        }

        static double CalculateAverageScore(double mathScore, double physicsScore, double chemistryScore)
        {
            return (mathScore + physicsScore + chemistryScore) / 3;
        }
        static string GetAcademicPerformance(double averageScore)
        {
            if (averageScore >= 8)
            {
                return "Giỏi";
            }
            else if (averageScore >= 6.5) 
            {
                return "Khá";
            }
            else if(averageScore >= 5) 
            {
                return "Trung bình";
            }
            else
            {
                return "Yếu";
            }
        }
        static int GenerateStudentId()
        {
            int maxId = 0;
            foreach(var student in students)
            {
                if(student.id > maxId)
                {
                    maxId = student.id;
                }
            }

            return maxId + 1;
        }

        // Ham cap nhat sinh vien theo ID
        static void UpdateStudent()
        {
            Console.Write("Nhập ID của sinh viên cần cập nhật: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.Find(s => s.id == id);
            if (student.id == 0)
            {
                Console.WriteLine($"Không tìm thấy sinh viên có ID {id}");
                return;
            }

            Console.WriteLine("Thông tin sinh viên:");
            Console.WriteLine("ID: " + student.id);
            Console.WriteLine("1. Tên: " + student.name);
            Console.WriteLine("2. Giới tính: " + student.gender);
            Console.WriteLine("3. Tuổi: " + student.age);
            Console.WriteLine("4. Điểm toán: " + student.mathScore);
            Console.WriteLine("5. Điểm lý: " + student.physicsScore);
            Console.WriteLine("6. Điểm hóa: " + student.chemistryScore);

            Console.WriteLine();
            Console.Write("Chọn thuộc tính cần cập nhật (1-6): ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Tên mới: ");
                    student.name = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Giới tính mới: ");
                    student.gender = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Tuổi mới: ");
                    student.age = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Điểm toán mới: ");
                    student.mathScore = double.Parse(Console.ReadLine());
                    student.averageScore = CalculateAverageScore(student.mathScore, student.physicsScore, student.chemistryScore);
                    student.academicPerformance = GetAcademicPerformance(student.averageScore);
                    break;
                case 5:
                    Console.Write("Điểm lý mới: ");
                    student.physicsScore = double.Parse(Console.ReadLine());
                    student.averageScore = CalculateAverageScore(student.mathScore, student.physicsScore, student.chemistryScore);
                    student.academicPerformance = GetAcademicPerformance(student.averageScore);
                    break;
                case 6:
                    Console.Write("Điểm hóa mới: ");
                    student.chemistryScore = double.Parse(Console.ReadLine());
                    student.averageScore = CalculateAverageScore(student.mathScore, student.physicsScore, student.chemistryScore);
                    student.academicPerformance = GetAcademicPerformance(student.averageScore);
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }
            // Cap nhat du lieu cho hoc sinh trong danh sach
            int index = students.FindIndex(s => s.id == id);
            students[index] = student;
            Console.WriteLine("Cập nhật thông tin sinh viên thành công.");
        }

        // Ham xoa sinh vien theo ID
        static void DeleteStudent()
        {
            Console.Write("Nhập ID của sinh viên cần xóa: ");
            int idToDelete = int.Parse(Console.ReadLine());

            int removeCount = students.FindIndex(student => student.id == idToDelete);

            if(removeCount != -1)
            {
                students.RemoveAt(removeCount);
                Console.WriteLine($"Đã xóa {removeCount} sinh viên có ID {idToDelete}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên có ID {idToDelete} để xóa.");
            }
        }

        // Ham tim kiem sinh vien theo ten
        static void SearchStudentByName()
        {
            Console.Write("Nhập tên sinh viên cần tìm: ");
            string searchName = Console.ReadLine();
            
            List<Student> matchStudents = students.FindAll(s => s.name.ToLower().Contains(searchName.ToLower()));
            if(matchStudents.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var st in matchStudents)
                {
                    ShowStudentList();
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có tên đã nhập.");
            }
        }

        // Ham sap xep danh sach theo diem trung binh
        static void SortStudentsByAverageScore()
        {
            students.Sort((s1, s2) => s2.averageScore.CompareTo(s1.averageScore));
            Console.WriteLine("Đã sắp xếp sinh viên theo điểm trung bình.");
        }

        // Ham sap xep danh sach theo ten sinh vien
        static void SortStudentsByName()
        {
            students.Sort((s1, s2) => string.Compare(s1.name, s2.name));
            Console.WriteLine("Đã sắp xếp sinh viên theo tên.");
        }

        // Ham hien thi danh sach sinh vien
        static void ShowStudentList()
        {
            Console.WriteLine("\n\t\t\t\tDANH SÁCH SINH VIÊN:");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("| ID |       Tên       | Giới tính | Tuổi | Toán | Lý  | Hóa | Điểm TB |   Học lực  |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"| {student.id,2} | {student.name,-15} | {student.gender,-9} | {student.age,4} | {student.mathScore,-4} | {student.physicsScore,-3} | {student.chemistryScore,-3} | {student.averageScore,-7:F2} | {student.academicPerformance,-10} |");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        // Ham ghi danh sach sinh vien vao file student.txt
        static void SaveStudentsToFile(string filename)
        {
            try
            {
                using (StreamWriter writeFile = new StreamWriter(filename))
                {
                    foreach (var student in students)
                    {
                        string studentData = $"{student.id},{student.name},{student.gender},{student.age},{student.mathScore},{student.physicsScore},{student.chemistryScore},{student.averageScore},{student.academicPerformance}";
                        writeFile.WriteLine(studentData);
                    }
                }

                Console.WriteLine("Danh sách sinh viên đã được lưu vào file 'student.txt'.");
            }
            catch (IOException)
            {
                Console.WriteLine("Lỗi ghi file.");
            }
        }
    }
}
