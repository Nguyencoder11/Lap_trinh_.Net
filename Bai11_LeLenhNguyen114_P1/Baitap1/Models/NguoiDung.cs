using System;
using System.Collections.Generic;

namespace BaiTap1.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string HoTen { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
