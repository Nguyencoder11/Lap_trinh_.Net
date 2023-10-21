using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Nhap ma khoa hoc: ");
            CourseId = Console.ReadLine();
            Console.Write("Nhap ten khoa hoc: ");
            CourseName = Console.ReadLine();
            Console.Write("Nhap hoc phi: ");
            Fee = int.Parse(Console.ReadLine());

            Console.Write("Nhap so luong sinh vien: ");
            int studentCount = int.Parse(Console.ReadLine());

            for(int i = 0; i < studentCount; i++)
            {
                Student student = new Student();
                student.InputStudent();
                Li.Add(student);
            }
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"Ma khoa hoc: {CourseId} Ten khoa hoc: {CourseName} Hoc phi: {Fee}");
            Console.WriteLine("Danh sach hoc sinh cua khoa hoc:");
            foreach(var student in Li)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
