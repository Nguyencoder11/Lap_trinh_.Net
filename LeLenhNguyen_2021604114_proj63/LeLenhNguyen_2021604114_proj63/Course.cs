using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeLenhNguyen_2021604114_proj63
{
    class Course
    {
        private string courseId;
        private string courseName;
        private int fee;
        List<Student> li;
        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int Fee
        {
            get { return fee; }
            set { fee = value; }    
        }
        public List<Student> Li
        {
            get { return li; }
            set { li = value; }
        }

        public Course()
        {
            CourseId = "";
            CourseName = "";
            Fee = 0;
            Li = new List<Student>();
        }

        public void InputCourse()
        {
            try
            {
                Console.Write("Nhap ma khoa hoc: ");
                CourseId = Console.ReadLine();
                Console.Write("Nhap ten khoa hoc: ");
                CourseName = Console.ReadLine();
                Console.Write("Nhap hoc phi: ");
                Fee = int.Parse(Console.ReadLine());

                Console.Write("Nhap so luong sinh vien: ");
                int studentCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < studentCount; i++)
                {
                    Student student = new Student();
                    student.InputStudent();
                    Li.Add(student);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi dinh dang");
            }
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("------- Thong tin khoa hoc -------");
            Console.WriteLine($"Ma khoa hoc: {CourseId} \nTen khoa hoc: {CourseName} \nHoc phi: {Fee}");
            Console.WriteLine("{0,10}{1,20}{2,12}", "Ma sinh vien", "Ho ten", "Diem");
            foreach(var student in Li)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
