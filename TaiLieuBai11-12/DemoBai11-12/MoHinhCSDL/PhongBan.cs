using System;
using System.Collections.Generic;

namespace DemoBai11_12.MoHinhCSDL;

public partial class PhongBan
{
    public string MaPb { get; set; } = null!;

    public string? TenPb { get; set; }

    public DateTime? NgayThanhLap { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();

    public int SoNamThanhLap
    {
        get
        {
            DateTime namtl = (DateTime)NgayThanhLap;
            return DateTime.Today.Year - namtl.Year;
        }
    }
}
