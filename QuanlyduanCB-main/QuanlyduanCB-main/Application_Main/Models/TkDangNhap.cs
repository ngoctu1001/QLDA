using System;
using System.Collections.Generic;

namespace QuanLyDuAnBDS.Models;

public partial class TkDangNhap
{
    public string? Chucdanh { get; set; }

    public string Idtk { get; set; } = null!;

    public string Tdn { get; set; } = null!;

    public string Mk { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int Gt { get; set; }

    public DateTime Ns { get; set; }

    public string? Gmail { get; set; }

    public string Sdt { get; set; } = null!;

    public virtual ICollection<DuAnChuaDuyet> DuAnChuaDuyets { get; set; } = new List<DuAnChuaDuyet>();

    public virtual ICollection<DuAnDaDuyet> DuAnDaDuyets { get; set; } = new List<DuAnDaDuyet>();
}
