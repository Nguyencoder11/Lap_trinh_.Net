using System;

public class MyProgram
{
    static void Main()
    {
        QuanLyNhanVien nhanvien = new QuanLyNhanVien();
        nhanvien.Input(1, "Nong Manh", DateTime.Now, 2.1, 1);
        Console.WriteLine(nhanvien.ToString());
    }
}
