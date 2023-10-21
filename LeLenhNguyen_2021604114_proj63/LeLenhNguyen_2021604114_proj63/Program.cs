using System;
using System.Collections.Generic;

namespace LeLenhNguyen_2021604114_proj63
{
    class Program
    {
        private static List<Course> coursesList = new List<Course>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------- MENU --------");
                Console.WriteLine("1. Them mot khoa hoc");
                Console.WriteLine("2. Hien thi cac khoa hoc");
                Console.WriteLine("3. Tim kiem khoa hoc");
                Console.WriteLine("4. Tim kiem sinh vien");
                Console.WriteLine("5. Xoa mot khoa hoc");
                Console.WriteLine("6. Ket thuc chuong trinh");

                Console.Write("Nhap vao lua chon: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemMotKhoaHoc();
                        break;
                    case 2:
                        Console.WriteLine("Danh sach cac khoa hoc");
                        HienThiKhoaHoc();
                        break;
                    case 3:
                        TimKiemKhoaHoc();
                        break;
                    case 4:
                        TimKiemSinhVien();
                        break;
                    case 5:
                        XoaMotKhoaHoc();
                        break;
                    case 6:
                        Console.WriteLine("Da thoat chuong trinh");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong phu hop");
                        break;
                }
            }
        }

        private static void XoaMotKhoaHoc()
        {
            Console.Write("Nhap vao ma khoa hoc: ");
            string deleteId = Console.ReadLine();

            foreach(var course in coursesList)
            {
                if(course != null && course.CourseId == deleteId)
                {
                    coursesList.Remove(course);
                }
            }
        }

        private static void TimKiemSinhVien()
        {
            Console.Write("Nhap ma sinh vien: ");
            int studentIdSearch = Convert.ToInt32(Console.ReadLine());

            foreach(var course in coursesList)
            {
                if(course!= null)
                {
                    foreach(var student in course.Li)
                    {
                        if(student.StudentId == studentIdSearch)
                        {
                            course.DisplayCourseAndStudents();
                            Console.WriteLine(student.ToString());
                        }
                    }
                }
            }
        }

        private static void TimKiemKhoaHoc()
        {
            Console.Write("Nhap vao ma khoa hoc: ");
            string courseSearch = Console.ReadLine();   

            foreach(var course in coursesList)
            {
                if(course != null && course.CourseId == courseSearch)
                {
                    course.DisplayCourseAndStudents();
                }
            }
        }

        private static void HienThiKhoaHoc()
        {
            foreach(var course in coursesList)
            {
                course.DisplayCourseAndStudents();
            }
        }

        private static void ThemMotKhoaHoc()
        {
            Console.WriteLine("Nhap vao mot khoa hoc:");
            Course newCourse = new Course();
            newCourse.InputCourse();
            coursesList.Add(newCourse);
        }
    }
}
