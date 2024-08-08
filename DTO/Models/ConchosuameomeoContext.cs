using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class ConchosuameomeoContext : DbContext
{
    public ConchosuameomeoContext()
    {
    }

    public ConchosuameomeoContext(DbContextOptions<ConchosuameomeoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cthd> Cthds { get; set; }

    public virtual DbSet<Ctsp> Ctsps { get; set; }

    public virtual DbSet<Giohang> Giohangs { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Xuatxu> Xuatxus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CIRYUKUU\\SQLEXPRESS;Database=conchosuameomeo;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cthd>(entity =>
        {
            entity.HasKey(e => e.MaCthd).HasName("PK__CTHD__1E4FA771E6D3292A");

            entity.ToTable("CTHD");

            entity.Property(e => e.MaCthd).HasColumnName("MaCTHD");
            entity.Property(e => e.Createat)
                .HasColumnType("datetime")
                .HasColumnName("createat");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.Soluong).HasColumnName("soluong");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            entity.Property(e => e.Updateat)
                .HasColumnType("datetime")
                .HasColumnName("updateat");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("updateby");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__MaHD__534D60F1");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__Manv__5441852A");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Cthds)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTHD__Masp__5535A963");
        });

        modelBuilder.Entity<Ctsp>(entity =>
        {
            entity.HasKey(e => e.Mactsp).HasName("PK__CTSP__50C457B45906D4C2");

            entity.ToTable("CTSP");

            entity.Property(e => e.Mactsp).HasColumnName("mactsp");
            entity.Property(e => e.Makc).HasColumnName("makc");
            entity.Property(e => e.Mams).HasColumnName("mams");
            entity.Property(e => e.Masp).HasColumnName("masp");
            entity.Property(e => e.Math).HasColumnName("math");
            entity.Property(e => e.Maxx).HasColumnName("maxx");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");

            entity.HasOne(d => d.MakcNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.Makc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__makc__440B1D61");

            entity.HasOne(d => d.MamsNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.Mams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__mams__4222D4EF");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__masp__412EB0B6");

            entity.HasOne(d => d.MathNavigation).WithMany(p => p.Ctsps)
                .HasForeignKey(d => d.Math)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CTSP__math__4316F928");
        });

        modelBuilder.Entity<Giohang>(entity =>
        {
            entity.HasKey(e => e.Magiohang).HasName("PK__Giohang__9114490360B0CC1B");

            entity.ToTable("Giohang");

            entity.Property(e => e.Magiohang).HasColumnName("magiohang");
            entity.Property(e => e.Gia)
                .HasColumnType("money")
                .HasColumnName("gia");
            entity.Property(e => e.Kichco).HasColumnName("kichco");
            entity.Property(e => e.Mausac)
                .HasMaxLength(50)
                .HasColumnName("mausac");
            entity.Property(e => e.Soluong).HasColumnName("soluong");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("tensp");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__Hoadon__2725A6E02BDB3040");

            entity.ToTable("Hoadon");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.Createat)
                .HasColumnType("datetime")
                .HasColumnName("createat");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Gia).HasColumnName("gia");
            entity.Property(e => e.MaKm).HasColumnName("MaKM");
            entity.Property(e => e.Ngaymua)
                .HasColumnType("datetime")
                .HasColumnName("ngaymua");
            entity.Property(e => e.Thanhtien).HasColumnName("thanhtien");
            entity.Property(e => e.Updateat)
                .HasColumnType("datetime")
                .HasColumnName("updateat");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("updateby");

            entity.HasOne(d => d.MaKmNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaKm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hoadon__MaKM__5070F446");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hoadon__Manv__4F7CD00D");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.Makm).HasName("PK__khuyenma__7A21BB47B5484971");

            entity.ToTable("khuyenmai");

            entity.Property(e => e.Makm).HasColumnName("makm");
            entity.Property(e => e.Ngaydung)
                .HasColumnType("datetime")
                .HasColumnName("ngaydung");
            entity.Property(e => e.Ngaykt)
                .HasColumnType("datetime")
                .HasColumnName("ngaykt");
            entity.Property(e => e.Ngaytao).HasColumnType("datetime");
            entity.Property(e => e.Phantramgiam)
                .HasMaxLength(10)
                .HasColumnName("phantramgiam");
            entity.Property(e => e.Tenkm)
                .HasMaxLength(90)
                .HasColumnName("tenkm");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makc).HasName("PK__kichco__7A21BB7128823CBA");

            entity.ToTable("kichco");

            entity.Property(e => e.Makc).HasColumnName("makc");
            entity.Property(e => e.Kichco1).HasColumnName("kichco");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mams).HasName("PK__mausac__7A21CB8306B2BCB0");

            entity.ToTable("mausac");

            entity.Property(e => e.Mams).HasColumnName("mams");
            entity.Property(e => e.Tenms)
                .HasMaxLength(50)
                .HasColumnName("tenms");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__nhanvien__7A21B37DA0789BF8");

            entity.ToTable("nhanvien");

            entity.Property(e => e.Manv).HasColumnName("manv");
            entity.Property(e => e.Createat)
                .HasColumnType("datetime")
                .HasColumnName("createat");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Diachi)
                .HasMaxLength(90)
                .HasColumnName("diachi");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Matk).HasColumnName("matk");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("ngaysinh");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(90)
                .HasColumnName("quoctich");
            entity.Property(e => e.Tennv)
                .HasMaxLength(50)
                .HasColumnName("tennv");
            entity.Property(e => e.Updateat)
                .HasColumnType("datetime")
                .HasColumnName("updateat");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("updateby");
            entity.Property(e => e.Vaitro)
                .HasMaxLength(50)
                .HasColumnName("vaitro");

            entity.HasOne(d => d.MatkNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Matk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__nhanvien__matk__4AB81AF0");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__Sanpham__7A217672A117D6F3");

            entity.ToTable("Sanpham");

            entity.Property(e => e.Masp).HasColumnName("masp");
            entity.Property(e => e.Gia)
                .HasColumnType("money")
                .HasColumnName("gia");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("tensp");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.MaTk).HasName("PK__taikhoan__27250070EA4D87C1");

            entity.ToTable("taikhoan");

            entity.Property(e => e.MaTk).HasColumnName("MaTK");
            entity.Property(e => e.Createat)
                .HasColumnType("datetime")
                .HasColumnName("createat");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Passwords)
                .HasMaxLength(20)
                .HasColumnName("passwords");
            entity.Property(e => e.Trangthai).HasColumnName("trangthai");
            entity.Property(e => e.Updateat)
                .HasColumnType("datetime")
                .HasColumnName("updateat");
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .HasColumnName("updateby");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Math).HasName("PK__thuonghi__7A217E6BB6CDD174");

            entity.ToTable("thuonghieu");

            entity.Property(e => e.Math).HasColumnName("math");
            entity.Property(e => e.Tenth)
                .HasMaxLength(50)
                .HasColumnName("tenth");
        });

        modelBuilder.Entity<Xuatxu>(entity =>
        {
            entity.HasKey(e => e.Maxx).HasName("PK__xuatxu__7A209E9EEBA32EB1");

            entity.ToTable("xuatxu");

            entity.Property(e => e.Maxx).HasColumnName("maxx");
            entity.Property(e => e.Tenxx)
                .HasMaxLength(50)
                .HasColumnName("tenxx");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
