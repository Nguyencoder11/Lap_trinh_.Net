using System;

public class QuanLyNhanVien : NhanVien
{
    private double hesophucap;

    public double HeSoPhuCap
    {
        get { return hesophucap; }
        set { hesophucap = value; }
    }

    public override void Input(int maNV, string hoTen, DateTime ngay, double hesoluong)
    {
        base.Input(maNV, hoTen, ngay, hesoluong);
    }

    public void Input(int maNV, string hoTen, DateTime ngay, double hesoluong, double hesophucap)
    {
        base.Input(maNV, hoTen, ngay, hesoluong);
        this.hesophucap = hesophucap;
    }

    public override double TinhLuong()
    {
        return (HeSoPhuCap + HeSoLuong) * 1800000;
    }

    public override string ToString()
    {
        return $"{MaNV}, {HoTen}, {Ngay.ToShortDateString()}, {HeSoLuong}, {HeSoPhuCap}";
    }
}
