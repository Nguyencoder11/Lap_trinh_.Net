using System;
using System.Collections.Generic;

namespace Bai12_Nguyen114_P1.DataModels;

public partial class HoaDonChiTiet
{
    public string MaHd { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public int? SoLuongMua { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
