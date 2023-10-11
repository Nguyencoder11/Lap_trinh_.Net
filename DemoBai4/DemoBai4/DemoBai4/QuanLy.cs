using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai4
{
    internal class QuanLy : NhanVien//Lớp Quản lý kế thừa lớp nhân viên
    {
        //Bổ sung biến thành viên private: hệ số phụ cấp
        private double _HeSoPhuCap;
        //Viết các thuộc tính cho phép truy cập an toàn biến thành viên hệ số phụ cấp
        public double HeSoPhuCap { get => _HeSoPhuCap; set => _HeSoPhuCap = value; }
                
        //Viết lại constructor cho lớp con
        public QuanLy(string maNhanVien, string hoTenNhanVien, DateTime ngaySinh, double heSoLuong, double heSoPhuCap):base(maNhanVien,hoTenNhanVien,ngaySinh,heSoLuong)//gọi constructor của lớp cha
        {
            HeSoPhuCap = heSoPhuCap;
        }
        //nạp đè constructor không tham sô
        public QuanLy() { }

        // nạp đè phương thức tính lương = (hệ số lương + hệ số phụ cấp)* 1.800.000
        public override double TinhLuong()
        {
            return (HeSoPhuCap + HeSoLuong) * 1800000;
        }

        //Nạp đè phương thức ToString để trả về thông tin của 1 đối tượng nhân viên quản lý trên một dòng
        public override string ToString()
        {
            return string.Format("{0,-15}{1,-20}{2,12:d}{3,15}{4,15}{5,15:N0}", this.MaNhanVien, HoTenNhanVien, NgaySinh, HeSoLuong,HeSoPhuCap, TinhLuong());
        }
    }
}
