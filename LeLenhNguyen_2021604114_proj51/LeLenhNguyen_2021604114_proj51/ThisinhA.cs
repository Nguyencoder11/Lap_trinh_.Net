using System;

namespace LeLenhNguyen_2021604114_proj51
{
    class ThisinhA
    {
        private string so_bao_danh;
        private string ho_ten;
        private string dia_chi;
        private double diem_toan, diem_ly, diem_hoa;
        private double diem_uu_tien, tong_diem;

        public string SoBaoDanh
        {
            get { return so_bao_danh; }
            set { so_bao_danh = value; }
        }

        public string HoTen
        {
            get => ho_ten;
            set => ho_ten = value;
        }

        public string DiaChi
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }

        public double DiemToan
        {
            get { return diem_toan; }
            set { diem_toan = value; }
        }
        public double DiemLy
        {
            get { return diem_ly; }
            set { diem_ly = value; }
        }
        public double DiemHoa
        {
            get { return diem_hoa; }
            set { diem_hoa = value; }
        }
        public double DiemUuTien
        {
            get { return diem_uu_tien; }
            set { diem_uu_tien = value; }
        }
        public double TongDiem
        {
            get { return tong_diem = diem_toan + diem_ly + diem_hoa; }
        }
        public ThisinhA(string sbd, string hoten, string diachi, double diemtoan, double diemly, double diemhoa, double diemuutien)
        {
            SoBaoDanh = sbd;
            HoTen = hoten;
            DiaChi = diachi;
            DiemToan = diemtoan;
            DiemLy = diemly;
            DiemHoa = diemhoa;
            DiemUuTien = diemuutien;
        }
        public override string ToString()
        {
            return string.Format("{0,12}{1,20}{2,15}{3,12}{4,12}{5,12}{6,15}{7,12}", SoBaoDanh, HoTen, DiaChi, DiemToan, DiemLy, DiemHoa, DiemUuTien, TongDiem);
        }
    }
}