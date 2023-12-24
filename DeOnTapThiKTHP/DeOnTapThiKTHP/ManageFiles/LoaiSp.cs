﻿using System;
using System.Collections.Generic;

namespace DeOnTapThiKTHP.ManageFiles;

public partial class LoaiSp
{
    public string MaLoai { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
