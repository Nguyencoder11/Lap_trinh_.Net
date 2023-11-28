using System;
using System.Collections.Generic;

namespace BaiTap1.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaHd { get; set; } = null!;
        public DateTime? NgayLap { get; set; }
        public string? MaKh { get; set; }
        public string? NguoiLap { get; set; }
        public string? TenDangNhap { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual NguoiDung? TenDangNhapNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
