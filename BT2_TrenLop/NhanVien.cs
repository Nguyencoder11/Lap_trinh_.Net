using System;

public class NhanVien
{
    private int maNV;
    private string hoTen;
    private DateTime ngay;
    private double hesoluong;

    public int MaNV
    {
        get => maNV;
        set => maNV = value;
    }

    public string HoTen
    {
        get => hoTen;
        set => hoTen = value;
    }

    public DateTime Ngay
    {
        get => ngay;
        set => ngay = value;
    }

    public double HeSoLuong
    {
        get => hesoluong;
        set => hesoluong = value;
    }

    public virtual void Input(int maNV, string hoTen, DateTime ngay, double hesoluong)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
        this.ngay = ngay;
        this.hesoluong = hesoluong;
    }

    public virtual double TinhLuong()
    {
        return hesoluong * 1800000;
    }

    public override string ToString()
    {
        return $"{maNV}, {hoTen}, {ngay.ToShortDateString()}, {hesoluong}";
    }
}
