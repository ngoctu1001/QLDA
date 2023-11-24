using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAnBDS.DomainClass;

[Table("DuAnDaDuyet")]
public partial class DuAnDaDuyet
{
    [Key]
    [Column("IDDADD")]
    [StringLength(5)]
    [Unicode(false)]
    public string Iddadd { get; set; } = null!;

    [StringLength(50)]
    public string TenDuAn { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string? Mota { get; set; }

    public int? Gia { get; set; }

    public double? Dientich { get; set; }

    [Column("IDTk")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Idtk { get; set; }

    [ForeignKey("Idtk")]
    [InverseProperty("DuAnDaDuyets")]
    public virtual TkDangNhap? IdtkNavigation { get; set; }
}
