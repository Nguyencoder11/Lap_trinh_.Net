using System;
using System.Collections.Generic;

namespace Bai12_Nguyen114_P1.DataModels;

public partial class NguoiDung
{
    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
