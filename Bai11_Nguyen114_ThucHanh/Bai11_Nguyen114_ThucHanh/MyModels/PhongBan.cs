using System;
using System.Collections.Generic;

namespace Bai11_Nguyen114_ThucHanh.MyModels;

public partial class PhongBan
{
    public string MaPb { get; set; } = null!;

    public string? TenPb { get; set; }

    public DateTime? NgayThanhLap { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
