using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoaOOP
{
    class KhachHang
    {
        private string ma_khach_hang;
        private string ho_ten;
        private int so_luong_mua;
        private double don_gia;

        public string MaKhachHang
        {
            get { return ma_khach_hang; }
            set { ma_khach_hang = value; }
        }
        public string HoTen
        {
            get { return ho_ten; }
            set { ho_ten = value; }
        }
        public int SoLuongMua
        {
            get { return so_luong_mua; }
            set { so_luong_mua = value; }
        }
        public double DonGia
        {
            get { return don_gia; }
            set { don_gia = value; }
        }

        public KhachHang()
        {
            MaKhachHang = "";
            HoTen = "";
            SoLuongMua = 0;
            DonGia = 0;
        }
        public KhachHang(string maKH, string hoTen, int soLuongMua, double donGia)
        {
            MaKhachHang = maKH;
            HoTen = hoTen;
            SoLuongMua = soLuongMua;
            DonGia = donGia;
        }

        public double TinhTongTien()
        {
            return SoLuongMua * DonGia;
        }

        public override string ToString()
        {
            return string.Format("{0,12}{1,20}{2,15}{3,12}{4,12}", MaKhachHang, HoTen, SoLuongMua, DonGia, TinhTongTien());
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            KhachHang kh = (KhachHang)obj;
            return MaKhachHang.Equals(kh.MaKhachHang) && HoTen.Equals(kh.HoTen) && SoLuongMua.Equals(kh.SoLuongMua) && DonGia.Equals(kh.DonGia);
        }
    }
}
