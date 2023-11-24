using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QuanLyDuAnBDS.DomainClass;

namespace QuanLyDuAnBDS.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DuAnChuaDuyet> DuAnChuaDuyets { get; set; }

    public virtual DbSet<DuAnDaDuyet> DuAnDaDuyets { get; set; }

    public virtual DbSet<TkDangNhap> TkDangNhaps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLBDS;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DuAnChuaDuyet>(entity =>
        {
            entity.HasKey(e => e.Iddacd).HasName("PK__DuAnChua__73CE20BE728798DD");

            entity.Property(e => e.Iddacd).IsFixedLength();
            entity.Property(e => e.Idtk).IsFixedLength();

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DuAnChuaDuyets).HasConstraintName("FK__DuAnChuaDu__IDTk__4CA06362");
        });

        modelBuilder.Entity<DuAnDaDuyet>(entity =>
        {
            entity.HasKey(e => e.Iddadd).HasName("PK__DuAnDaDu__73CE289873DABC59");

            entity.Property(e => e.Iddadd).IsFixedLength();
            entity.Property(e => e.Idtk).IsFixedLength();

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DuAnDaDuyets).HasConstraintName("FK__DuAnDaDuye__IDTk__4F7CD00D");
        });

        modelBuilder.Entity<TkDangNhap>(entity =>
        {
            entity.HasKey(e => e.Idtk).HasName("PK__TkDangNh__B87C3AE3632033D2");

            entity.Property(e => e.Idtk).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
