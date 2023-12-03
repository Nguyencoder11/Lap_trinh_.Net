using System;
using System.Collections.Generic;

namespace Bai12_Nguyen114_P1.DataModels;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public DateTime? NgayLap { get; set; }

    public string? MaKh { get; set; }

    public string? NguoiLap { get; set; }

    public string? TenDangNhap { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NguoiDung? TenDangNhapNavigation { get; set; }
}
