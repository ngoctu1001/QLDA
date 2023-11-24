using System;
using System.Collections.Generic;

namespace QuanLyDuAnBDS.Models;

public partial class DuAnDaDuyet
{
    public string Iddadd { get; set; } = null!;

    public string TenDuAn { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string? Mota { get; set; }

    public int? Gia { get; set; }

    public double? Dientich { get; set; }

    public string? Idtk { get; set; }

    public virtual TkDangNhap? IdtkNavigation { get; set; }
}
