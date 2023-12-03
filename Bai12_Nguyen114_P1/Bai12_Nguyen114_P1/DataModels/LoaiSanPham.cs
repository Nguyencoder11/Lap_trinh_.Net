using System;
using System.Collections.Generic;

namespace Bai12_Nguyen114_P1.DataModels;

public partial class LoaiSanPham
{
    public string MaLoai { get; set; } = null!;

    public string TenLoai { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
