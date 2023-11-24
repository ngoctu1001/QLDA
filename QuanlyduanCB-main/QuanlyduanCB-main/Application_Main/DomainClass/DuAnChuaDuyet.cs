using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAnBDS.DomainClass;

[Table("DuAnChuaDuyet")]
public partial class DuAnChuaDuyet
{
    [Key]
    [Column("IDDACD")]
    [StringLength(5)]
    [Unicode(false)]
    public string Iddacd { get; set; } = null!;

    [StringLength(50)]
    public string TenDuAn { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string? Mota { get; set; }

    public int? Gia { get; set; }

    public double? Dientich { get; set; }

    [Column("IDTk")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Idtk { get; set; }

    [ForeignKey("Idtk")]
    [InverseProperty("DuAnChuaDuyets")]
    public virtual TkDangNhap? IdtkNavigation { get; set; }
}
