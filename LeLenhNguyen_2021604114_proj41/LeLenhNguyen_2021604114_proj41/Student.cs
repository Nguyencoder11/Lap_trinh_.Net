using System;

namespace LeLenhNguyen_2021604114_proj41
{
    class Student
    {
        private string id;
        private string name;
        private int mark;
        private int scholarship;

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetId()
        {
            return id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetMark(int mark)
        {
            this.mark = mark;
        }

        public int GetMark()
        {
            return mark;
        }


        public Student()
        {
            // Khởi tạo một đối tượng Student không tham số
            id = "";
            name = "";
            mark = 0;
            scholarship = 0;
        }

        public Student(string id)
        {
            // Khởi tạo một đối tượng Student với tham số id
            this.id = id;
            name = "";
            mark = 0;
            scholarship = 0;
        }

        public Student(string id, string name, int mark)
        {
            // Khởi tạo một đối tượng Student với tất cả các tham số
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public int GetScholarship()
        {
            if (mark > 8)
                scholarship = 500;
            else if (mark >= 7 && mark <= 8)
                scholarship = 300;
            else
                scholarship = 0;
            return scholarship;
        }
    }
}