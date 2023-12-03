using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bai12_Nguyen114_P1.DataModels;

public partial class QlbhContext : DbContext
{
    public QlbhContext()
    {
    }

    public QlbhContext(DbContextOptions<QlbhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-114BJP49\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E0F9C2C080");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.NgayLap).HasColumnType("date");
            entity.Property(e => e.NguoiLap)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("fk_hd_kh");

            entity.HasOne(d => d.TenDangNhapNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.TenDangNhap)
                .HasConstraintName("fk_hd_nd");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaSp }).HasName("pk_hdct");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.MaHd)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaSp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hdct_hd");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hdct_sp");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EE6E559CF");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.SoDt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SoDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LoaiSanP__730A575920BD05D8");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.MaLoai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__NguoiDun__55F68FC1408BB58F");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C2AA2E43E");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("fk_sp_lsp");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
