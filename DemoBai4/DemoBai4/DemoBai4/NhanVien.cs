using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoBai4
{    
      internal class NhanVien:IComparable //thực thi giao diện IComparable
    {
        #region Biến thành viên - Thuộc tính
        //biến thành viên private: Mã nhân viên, họ tên, ngày sinh(kiểu DateTime), hệ số lương
        //thuộc tính cho phép truy cập an toàn các biến thành viên
        private string _MaNhanVien;//biến thành viên private - lưu giá trị của thuộc tính
        public string MaNhanVien//thuộc tính
        {
            get { return _MaNhanVien; }//lấy giá trị của thuộc tính
            set { _MaNhanVien = value; }//gán giá trị cho thuộc tính
        }

        private string _HoTenNhanVien;
        public string HoTenNhanVien //thuộc tính
        {
            get => _HoTenNhanVien; //viết theo cú pháp lambda - học ở bài 7
            set => _HoTenNhanVien = value;
        }

        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private double _HeSoLuong;
        public double HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }

        static private int _SoLuongNhanVien;//biến lưu số lượng đối tượng nhân viên được khởi tạo
        static public int SoLuongNhanVien
        {
            get { return _SoLuongNhanVien; }
            private set { _SoLuongNhanVien = value; }
        }

        #endregion

        //Viết phương thức nhập thông tin(có số tham số bằng số thuộc tính của lớp) và phương thức tính -- NÊN THAY BẰNG CONSTRUCTOR
        public void Nhap(string maNhanVien, string hoTenNhanVien, DateTime ngaySinh, double heSoLuong)
        {
            //Gán giá trị thuộc tính của đối tượng hiện tại bằng giá trị của tham số tương ứng
            this.MaNhanVien = maNhanVien;//từ khóa this chỉ đối tượng hiện hành, có thể bỏ
            this.HoTenNhanVien = hoTenNhanVien;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
        }

        //nên dùng constructor thay cho phương thức nhập
        //constructor 4 tham số
        public NhanVien(string maNhanVien, string hoTenNhanVien, DateTime ngaySinh, double heSoLuong)
        {
            MaNhanVien = maNhanVien;
            HoTenNhanVien = hoTenNhanVien;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            SoLuongNhanVien++;
        }
        //nạp chồng constructor không tham số
        public NhanVien() 
        {
            SoLuongNhanVien++;//tăng số lượng đối tượng đã được khởi tạo lên 1
        }

        //phương thức tính lương = hệ số lương * 1.800.000
        virtual public double TinhLuong()
        {
            return HeSoLuong * 1800000;
        }
        //Nạp đè phương thức ToString để trả về thông tin của 1 đối tượng nhân viên trên một dòng
        public override string ToString()
        {
            return string.Format("{0,-15}{1,-20}{2,12:d}{3,15}{4,15}{5,15:N0}", this.MaNhanVien, HoTenNhanVien, NgaySinh, HeSoLuong,"-", TinhLuong());
        }

        //nạp đè Equals để định nghĩa hai nhân viên bằng nhau là hai nhân viên có mã bằng nhau
        public override bool Equals(object? obj)
        {
            NhanVien nv = (NhanVien)obj;
            return MaNhanVien.Equals(nv.MaNhanVien);
        }

        //thực thi phương thức của giao diện để so sánh hai đối tượng nhân viên
        public int CompareTo(object? obj)
        {
            //so sánh hai nhân viên bằng trường hệ số lương
            //nếu lương bằng nhau thì sắp xếp tăng dần theo họ tên
            NhanVien nv = (NhanVien)obj;
            if (HeSoLuong == nv.HeSoLuong)
                return HoTenNhanVien.CompareTo(nv.HoTenNhanVien);//sắp xếp tăng dần
            else 
                return - HeSoLuong.CompareTo(nv.HeSoLuong);//sắp xếp giảm dần
        }
    }
}
