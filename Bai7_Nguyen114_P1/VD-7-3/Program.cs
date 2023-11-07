using System;

namespace VD_7_3
{
    internal class Program
    {
        // Khai báo ủy quyền
        delegate void HienThiThongBao(string thongbao);
        static void Main(string[] args)
        {
            // Khoi tao uy quyen del1, dong goi phuong thuc ThongBaoLoi
            HienThiThongBao del1 = ThongBaoLoi;

            // Khoi tao uy quyen del2, dong goi phuong thuc GuiThongDiep
            HienThiThongBao del2 = GuiThongDiep;

            // Khai bao uy quyen multicast
            HienThiThongBao multidel;

            // Khoi tao uy quyen multicast
            multidel = del1 + del2;
            // Sau khi thuc hien lenh multidel = del1 + del2; danh sach
            // goi uy quyen multidel gom co 2 phuong thuc la
            // ThongBaoLoi va GuiThongDiep

            HienThiThongBao del3 = CanhBao;
            multidel += del3;
            // Sau khi thuc hien lenh multidel += del3; danh sach goi cua
            // uy quyen multidel co 3 phuong thuc la 
            // ThongBaoLoi, GuiThongDiep va CanhBao

            multidel += CanhBao;
            multidel += CanhBao;
            // Sau khi thuc hien multidel += CanhBao; 2 lan uy quyen 
            // multidel se goi phuong thuc ThongBaoLoi 1 lan, GuiThongDiep 1 lan, CanhBao 3 lan

            multidel -= del2;
            // Sau khi thuc hien multidel -= del2; uy quyen multidel se 
            // goi phuong thuc ThongBaoLoi 1 lan va CanhBao 3 lan. 
            // phuong thuc GuiThongDiep da bi xoa khoi danh sach goi
            multidel("ABC");

        }
        // Khai báo phương thức tương đồng với ủy quyền HienThiThongBao
        // (tham số, kiểu trả về).
        static void ThongBaoLoi(string loi)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nChuong trinh cua ban co loi bien dich sau: {0}", loi);
            Console.ResetColor();
        }

        // Phương thức cũng có signature tương đồng với ủy quyền
        static void GuiThongDiep(string ten)
        {
            Console.WriteLine($"\nThing diep da duoc gui cho {ten}");
        }

        // Phương thức cũng có signature tương đồng với ủy quyền
        static void CanhBao(string phienBan)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nBan nen dung phien ban {0}", phienBan);
            Console.ResetColor();
        }
    }
}
