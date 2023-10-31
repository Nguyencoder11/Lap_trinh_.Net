// See https://aka.ms/new-console-template for more information
using DeKiemTraTX1;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<NhanVien> danhSachNhanVien = new List<NhanVien>();

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Thêm nhân viên");
    Console.WriteLine("2. Hiển thị danh sách");
    Console.WriteLine("3. Sắp xếp danh sách");
    Console.WriteLine("4. Thoát");
    Console.Write("Chọn chức năng: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ThemNhanVien();
            break;
        case "2":
            HienThiDanhSach();
            break;
        case "3":
            SapXepDanhSach();
            break;
        case "4":
            Console.WriteLine("Đã thoát chương trình");
            return;
        default:
            Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
            break;
    }
}

void ThemNhanVien()
{
    Console.Write("Mã nhân viên: ");
    string manv = Console.ReadLine();
    if(danhSachNhanVien.Any(nv => nv.Id == manv))
    {
        Console.WriteLine("Mã nhân viên đã tồn tại.");
        return;
    }
    Console.Write("Họ tên: ");
    string hoten = Console.ReadLine();
    Console.Write("Tuổi: ");
    int tuoi = int.Parse(Console.ReadLine());
    Console.Write("Giới tính: ");
    string gioitinh = Console.ReadLine();
    Console.Write("Địa chỉ: ");
    string diachi = Console.ReadLine();
    Console.Write("Chức vụ: ");
    string chucvu = Console.ReadLine();
    Console.Write("Lương cơ bản: ");
    double luongcb = double.Parse(Console.ReadLine());

    NhanVien newEmployee = new NhanVien(manv, hoten, tuoi, gioitinh, diachi, chucvu, luongcb);
    danhSachNhanVien.Add(newEmployee);
    Console.WriteLine("Đã thêm nhân viên mới thành công");
}

void HienThiDanhSach()
{
    if(danhSachNhanVien.Count == 0)
    {
        Console.WriteLine("Danh sách trống.");
        return;
    }
    Console.WriteLine("Danh sách sinh viên:");
    Console.WriteLine("{0,12}{1,20}{2,10}{3,15}{4,15}{5,15}{6,14}{7,14}", "Mã NV", "Họ tên", "Tuổi", "Giới tính", "Địa chỉ", "Chức vụ", "Lương cơ bản", "Hệ số chức vụ");
    foreach(var nv in danhSachNhanVien)
    {
        Console.WriteLine(nv.ToString());
    }
}

void SapXepDanhSach()
{
    danhSachNhanVien.Sort((nv1, nv2) =>
    {
        if (nv1.HeSoChucVu == nv2.HeSoChucVu)
        {
            return nv1.BasicSalary.CompareTo(nv2.BasicSalary);
        }
        return nv1.HeSoChucVu.CompareTo(nv2.HeSoChucVu);
    });
}