// See https://aka.ms/new-console-template for more information


using System.Net;
using System.Xml.Linq;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Student> students = new List<Student>();
while (true)
{
    Console.WriteLine("MENU:");
    Console.WriteLine("1. Thêm một sinh viên");
    Console.WriteLine("2. Hiển thị danh sách sinh viên");
    Console.WriteLine("3. Tìm kiếm sinh viên theo id");
    Console.WriteLine("4. Tìm kiếm sinh viên theo address");
    Console.WriteLine("5. Xoá một sinh viên theo id");
    Console.WriteLine("6. Kết thúc chương trình");
    Console.Write("Nhập lựa chọn: ");
    string option =  Console.ReadLine();
    switch (option)
    {
        case "1":
            ThemMotSinhVien(students);
            break;
        case "2":
            HienThiDanhSachSV(students);
            break;
        case "3":
            TimKiemTheoId(students);
            break;
        case "4":
            TimKiemTheoAddress(students);
            break;
        case "5":
            XoaMotSinhVienTheoId(students);
            break;
        case "6":
            Console.WriteLine("Đã thoát chương trình!");
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại:");
            break;
    }
}

void ThemMotSinhVien(List<Student> students)
{
    Console.WriteLine("Nhập thông tin sinh viên:");
    Student student = new Student();
    student.Input();
    students.Add(student);
    Console.WriteLine("Sinh viên được thêm thành công");
}
void HienThiDanhSachSV(List<Student> students)
{
    Console.WriteLine("{0,8}{1,20}{2,20}{3,12}{4,12}{5,12}", "ID", "Họ và tên", "Địa chỉ", "Điểm Toán", "Điểm Lý", "Tổng Điểm");
    Console.WriteLine("--------------------------------------------------------------------------------------");
    foreach (Student student in students)
    {
        student.Output();
    }
    Console.WriteLine("\n--------------------------------------------------------------------------------------");
}
void TimKiemTheoId(List<Student> students)
{
    Console.WriteLine("Nhập ID của sinh viên: ");
    int ID = Convert.ToInt32(Console.ReadLine());
    bool check = false;

    foreach (Student student in students)
    {
        if (student.Id == ID)
        {
            student.Output();
            check = true;
            return;
        }
    }
    if (!check)
    {
        Console.WriteLine($"Không tìm thấy sinh viên có ID là {ID}");
    }
}
void TimKiemTheoAddress(List<Student> students)
{
    Console.WriteLine("Nhập địa chỉ tìm kiếm: ");
    string address = Console.ReadLine();
    bool founded = false;

    Console.WriteLine($"Danh sách sinh viên có địa chỉ {address}");
    foreach (Student student in students)
    {
        if(student.Address.ToLower().Contains(address.ToLower()))
        {
            student.Output();
            founded = true;
        }
    }
    if ( !founded ) {
        Console.WriteLine($"Không tìm thấy sinh viên nào ở địa chỉ {address}");
    }
}
void XoaMotSinhVienTheoId(List<Student> students)
{
    Console.WriteLine("Nhập ID của sinh viên cần xóa: ");
    int deleteID = Convert.ToInt32(Console.ReadLine());

    for(int i=0; i<students.Count; i++)
    {
        if (students[i].Id == deleteID)
        {
            Console.WriteLine("Đã xóa sinh viên: ");
            students[i].Output();
            students.RemoveAt(i);
            return;
        }
    }
    Console.WriteLine($"Không tìm thấy sinh viên có ID là {deleteID} để xóa.");
}
