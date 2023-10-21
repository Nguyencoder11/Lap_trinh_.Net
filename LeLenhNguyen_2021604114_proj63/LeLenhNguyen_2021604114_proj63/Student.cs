using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeLenhNguyen_2021604114_proj63
{
    class Student
    {
        private int studentId;
        private string name;
        private string mark;
        
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public void InputStudent()
        {
            try
            {
                Console.Write("Nhap ma sinh vien: ");
                StudentId = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten: ");
                Name = Console.ReadLine();
                Console.Write("Nhap diem: ");
                Mark = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Du lieu nhap vao khong dung dinh dang");
            }
        }
        public override string ToString()
        {
            return string.Format("{0,10}{1,20}{2,12}", StudentId, Name, Mark);
        }
    }
}
