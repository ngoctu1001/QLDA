using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAnBDS.Models;

public partial class QlbdsContext : DbContext
{
    public QlbdsContext()
    {
    }

    public QlbdsContext(DbContextOptions<QlbdsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DuAnChuaDuyet> DuAnChuaDuyets { get; set; }

    public virtual DbSet<DuAnDaDuyet> DuAnDaDuyets { get; set; }

    public virtual DbSet<TkDangNhap> TkDangNhaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ONLYK;Initial Catalog=QLBDS;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DuAnChuaDuyet>(entity =>
        {
            entity.HasKey(e => e.Iddacd).HasName("PK__DuAnChua__73CE20BECA02F51C");

            entity.ToTable("DuAnChuaDuyet");

            entity.Property(e => e.Iddacd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDACD");
            entity.Property(e => e.Idtk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTk");
            entity.Property(e => e.TenDuAn).HasMaxLength(50);

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DuAnChuaDuyets)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK__DuAnChuaDu__IDTk__38996AB5");
        });

        modelBuilder.Entity<DuAnDaDuyet>(entity =>
        {
            entity.HasKey(e => e.Iddadd).HasName("PK__DuAnDaDu__73CE289836BF8866");

            entity.ToTable("DuAnDaDuyet");

            entity.Property(e => e.Iddadd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDDADD");
            entity.Property(e => e.Idtk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTk");
            entity.Property(e => e.TenDuAn).HasMaxLength(50);

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DuAnDaDuyets)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK__DuAnDaDuye__IDTk__3B75D760");
        });

        modelBuilder.Entity<TkDangNhap>(entity =>
        {
            entity.HasKey(e => e.Idtk).HasName("PK__TkDangNh__B87C3AE3EF7B53D8");

            entity.ToTable("TkDangNhap");

            entity.Property(e => e.Idtk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IDTk");
            entity.Property(e => e.Chucdanh).HasMaxLength(10);
            entity.Property(e => e.Gt).HasColumnName("GT");
            entity.Property(e => e.Ns)
                .HasColumnType("date")
                .HasColumnName("NS");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .HasColumnName("SDT");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
