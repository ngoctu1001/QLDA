using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAnBDS.DomainClass;

[Table("TkDangNhap")]
public partial class TkDangNhap
{
    [StringLength(10)]
    public string? Chucdanh { get; set; }

    [Key]
    [Column("IDTk")]
    [StringLength(5)]
    [Unicode(false)]
    public string Idtk { get; set; } = null!;

    public string Tdn { get; set; } = null!;

    public string Mk { get; set; } = null!;

    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("GT")]
    public int Gt { get; set; }

    [Column("NS", TypeName = "date")]
    public DateTime Ns { get; set; }

    public string? Gmail { get; set; }

    [Column("SDT")]
    [StringLength(10)]
    public string Sdt { get; set; } = null!;

    [InverseProperty("IdtkNavigation")]
    public virtual ICollection<DuAnChuaDuyet> DuAnChuaDuyets { get; set; } = new List<DuAnChuaDuyet>();

    [InverseProperty("IdtkNavigation")]
    public virtual ICollection<DuAnDaDuyet> DuAnDaDuyets { get; set; } = new List<DuAnDaDuyet>();
}
