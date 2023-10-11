using System;

namespace LeLenhNguyen_2021604114_proj41
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Bai tap 1
            Console.WriteLine(">>>>>----- Bai tap 1: -----<<<<<");
            Person person = new Person();
            person.Input();
            person.Output();
            person.CheckAge(); 


            // Bai tap 2
            Console.WriteLine("\n>>>>>----- Bai tap 2: -----<<<<<");
            Circle circle1 = new Circle();
            Console.WriteLine("Hinh tron 1:");
            Console.WriteLine($"Ban kinh: {circle1.getRadius()}");
            Console.WriteLine($"Dien tich: {circle1.Area()}");
            Console.WriteLine($"Chu vi: {circle1.Perimeter()}");

            Circle circle2 = new Circle(5.0);
            Console.WriteLine("Hinh tron 2:");
            Console.WriteLine($"Ban kinh: {circle2.getRadius()}");
            Console.WriteLine($"Dien tich: {circle2.Area()}");
            Console.WriteLine($"Chu vi: {circle2.Perimeter()}");
            

            // Bai tap 3
            Console.WriteLine("\n>>>>>----- Bai tap 3: -----<<<<<");
            Student student1 = new Student(); // Khởi tạo một sinh viên không tham số
            student1.SetId("S001");
            student1.SetName("John");
            student1.SetMark(9);
            Console.WriteLine("Thông tin sinh viên 1:");
            Console.WriteLine("ID: " + student1.GetId());
            Console.WriteLine("Tên: " + student1.GetName());
            Console.WriteLine("Điểm: " + student1.GetMark());
            Console.WriteLine("Học bổng: " + student1.GetScholarship());

            Console.WriteLine();

            Student student2 = new Student("S002"); // Khởi tạo một sinh viên với tham số id
            student2.SetName("Jane");
            student2.SetMark(7);
            Console.WriteLine("Thông tin sinh viên 2:");
            Console.WriteLine("ID: " + student2.GetId());
            Console.WriteLine("Tên: " + student2.GetName());
            Console.WriteLine("Điểm: " + student2.GetMark());
            Console.WriteLine("Học bổng: " + student2.GetScholarship());

            Console.WriteLine();

            Student student3 = new Student("S003", "Mike", 6); // Khởi tạo một sinh viên với tất cả các tham số
            Console.WriteLine("Thông tin sinh viên 3:");
            Console.WriteLine("ID: " + student3.GetId());
            Console.WriteLine("Tên: " + student3.GetName());
            Console.WriteLine("Điểm: " + student3.GetMark());
            Console.WriteLine("Học bổng: " + student3.GetScholarship());

            Console.ReadLine();
        }
    }
}
