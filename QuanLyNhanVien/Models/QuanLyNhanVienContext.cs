using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class QuanLyNhanVienContext : DbContext
    {
        public QuanLyNhanVienContext()
        {
        }

        public QuanLyNhanVienContext(DbContextOptions<QuanLyNhanVienContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoHiem> BaoHiem { get; set; }
        public virtual DbSet<ChamCong> ChamCong { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<DmheSoPhuCap> DmheSoPhuCap { get; set; }
        public virtual DbSet<Dmhsluong> Dmhsluong { get; set; }
        public virtual DbSet<Dmluong> Dmluong { get; set; }
        public virtual DbSet<DmmucPhuCap> DmmucPhuCap { get; set; }
        public virtual DbSet<DongBaoHiem> DongBaoHiem { get; set; }
        public virtual DbSet<LichLamViec> LichLamViec { get; set; }
        public virtual DbSet<LuongCoBan> LuongCoBan { get; set; }
        public virtual DbSet<NhanSu> NhanSu { get; set; }
        public virtual DbSet<Phat> Phat { get; set; }
        public virtual DbSet<PhongBan> PhongBan { get; set; }
        public virtual DbSet<PhuCapNhanSu> PhuCapNhanSu { get; set; }
        public virtual DbSet<QtchucVu> QtchucVu { get; set; }
        public virtual DbSet<QtcongTac> QtcongTac { get; set; }
        public virtual DbSet<QuaTrinhDongBh> QuaTrinhDongBh { get; set; }
        public virtual DbSet<QuaTrinhDongThue> QuaTrinhDongThue { get; set; }
        public virtual DbSet<QuaTrinhLuong> QuaTrinhLuong { get; set; }
        public virtual DbSet<QuaTrinhPhat> QuaTrinhPhat { get; set; }
        public virtual DbSet<QuaTrinhPhuCap> QuaTrinhPhuCap { get; set; }
        public virtual DbSet<QuaTrinhThuongPc> QuaTrinhThuongPc { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<Thue> Thue { get; set; }
        public virtual DbSet<ThueNhanSu> ThueNhanSu { get; set; }
        public virtual DbSet<ThuongPckhac> ThuongPckhac { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JVIBODN;Initial Catalog=QuanLyNhanVien;Persist Security Info=True;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHiem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaBh)
                    .IsRequired()
                    .HasColumnName("MaBH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tgad)
                    .HasColumnName("TGAD")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ChamCong>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.Thu)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.ChamCong)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_ChamCong_NhanSu");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CapCv).HasColumnName("CapCV");

                entity.Property(e => e.MaCv)
                    .IsRequired()
                    .HasColumnName("MaCV")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenChucVu).HasMaxLength(100);
            });

            modelBuilder.Entity<DmheSoPhuCap>(entity =>
            {
                entity.ToTable("DMHeSoPhuCap");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bhxh).HasColumnName("BHXH");

                entity.Property(e => e.MaHspc)
                    .IsRequired()
                    .HasColumnName("MaHSPC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tncn).HasColumnName("TNCN");
            });

            modelBuilder.Entity<Dmhsluong>(entity =>
            {
                entity.ToTable("DMHSLuong");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaHsl)
                    .IsRequired()
                    .HasColumnName("MaHSL")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dmluong>(entity =>
            {
                entity.ToTable("DMLuong");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaMl)
                    .IsRequired()
                    .HasColumnName("MaML")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NgayAd)
                    .HasColumnName("NgayAD")
                    .HasColumnType("date");

                entity.Property(e => e.TienLuong).HasColumnType("money");
            });

            modelBuilder.Entity<DmmucPhuCap>(entity =>
            {
                entity.ToTable("DMMucPhuCap");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KhoanPhuCap)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MaPc)
                    .IsRequired()
                    .HasColumnName("MaPC")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DongBaoHiem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.Property(e => e.TienBh)
                    .HasColumnName("TienBH")
                    .HasColumnType("money");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.DongBaoHiem)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_DongBaoHiem_NhanSu");
            });

            modelBuilder.Entity<LichLamViec>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rachieu).HasColumnName("rachieu");

                entity.Property(e => e.Rasang).HasColumnName("rasang");

                entity.Property(e => e.Ratoi).HasColumnName("ratoi");

                entity.Property(e => e.Vaochieu).HasColumnName("vaochieu");

                entity.Property(e => e.Vaosang).HasColumnName("vaosang");

                entity.Property(e => e.Vaotoi).HasColumnName("vaotoi");
            });

            modelBuilder.Entity<LuongCoBan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hsl).HasColumnName("HSL");

                entity.Property(e => e.Luong).HasColumnType("money");

                entity.Property(e => e.LuongNs)
                    .HasColumnName("LuongNS")
                    .HasColumnType("money");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.LuongCoBan)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_LuongCoBan_NhanSu");
            });

            modelBuilder.Entity<NhanSu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.MaNs)
                    .IsRequired()
                    .HasColumnName("MaNS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QueQuan).HasMaxLength(200);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenNs)
                    .HasColumnName("TenNS")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Phat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaPhat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoiDung).HasMaxLength(200);
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaPb)
                    .IsRequired()
                    .HasColumnName("MaPB")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenPhongBan).HasMaxLength(100);
            });

            modelBuilder.Entity<PhuCapNhanSu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hspc).HasColumnName("HSPC");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.Maphucap).HasMaxLength(100);

                entity.Property(e => e.ThoiGian).HasColumnType("date");

                entity.Property(e => e.TienPc).HasColumnName("TienPC");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.PhuCapNhanSu)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_PhuCapNhanSu_NhanSu");
            });

            modelBuilder.Entity<QtchucVu>(entity =>
            {
                entity.ToTable("QTChucVu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaCv).HasColumnName("MaCV");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.MaPb).HasColumnName("MaPB");

                entity.Property(e => e.TgbatDau)
                    .HasColumnName("TGBatDau")
                    .HasColumnType("date");

                entity.Property(e => e.TgketThuc)
                    .HasColumnName("TGKetThuc")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaCvNavigation)
                    .WithMany(p => p.QtchucVu)
                    .HasForeignKey(d => d.MaCv)
                    .HasConstraintName("FK_QuaTrinhChucVu_ChucVu");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QtchucVu)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhChucVu_NhanSu");

                entity.HasOne(d => d.MaPbNavigation)
                    .WithMany(p => p.QtchucVu)
                    .HasForeignKey(d => d.MaPb)
                    .HasConstraintName("FK_QTChucVu_PhongBan");
            });

            modelBuilder.Entity<QtcongTac>(entity =>
            {
                entity.ToTable("QTCongTac");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.MaPb).HasColumnName("MaPB");

                entity.Property(e => e.TgbatDau)
                    .HasColumnName("TGBatDau")
                    .HasColumnType("date");

                entity.Property(e => e.TgketThuc)
                    .HasColumnName("TGKetThuc")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QtcongTac)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhCongTac_NhanSu");

                entity.HasOne(d => d.MaPbNavigation)
                    .WithMany(p => p.QtcongTac)
                    .HasForeignKey(d => d.MaPb)
                    .HasConstraintName("FK_QuaTrinhCongTac_PhongBan");
            });

            modelBuilder.Entity<QuaTrinhDongBh>(entity =>
            {
                entity.ToTable("QuaTrinhDongBH");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaBh).HasColumnName("MaBH");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.TgbatDau)
                    .HasColumnName("TGBatDau")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaBhNavigation)
                    .WithMany(p => p.QuaTrinhDongBh)
                    .HasForeignKey(d => d.MaBh)
                    .HasConstraintName("FK_QuaTrinhDongBH_BaoHiem");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhDongBh)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhDongBH_NhanSu");
            });

            modelBuilder.Entity<QuaTrinhDongThue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.NgayBd)
                    .HasColumnName("NgayBD")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhDongThue)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhDongThue_NhanSu");

                entity.HasOne(d => d.MaThueNavigation)
                    .WithMany(p => p.QuaTrinhDongThue)
                    .HasForeignKey(d => d.MaThue)
                    .HasConstraintName("FK_QuaTrinhDongThue_Thue");
            });

            modelBuilder.Entity<QuaTrinhLuong>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaHsl).HasColumnName("MaHSL");

                entity.Property(e => e.MaMl).HasColumnName("MaML");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.TgbatDau)
                    .HasColumnName("TGBatDau")
                    .HasColumnType("date");

                entity.Property(e => e.TgketThuc)
                    .HasColumnName("TGKetThuc")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaHslNavigation)
                    .WithMany(p => p.QuaTrinhLuong)
                    .HasForeignKey(d => d.MaHsl)
                    .HasConstraintName("FK_QuaTrinhLuong_DMHSLuong");

                entity.HasOne(d => d.MaMlNavigation)
                    .WithMany(p => p.QuaTrinhLuong)
                    .HasForeignKey(d => d.MaMl)
                    .HasConstraintName("FK_QuaTrinhLuong_DMLuong");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhLuong)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhLuong_NhanSu");
            });

            modelBuilder.Entity<QuaTrinhPhat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.Tgphat)
                    .HasColumnName("TGPhat")
                    .HasColumnType("date");

                entity.Property(e => e.TienPhat).HasColumnType("money");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhPhat)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhPhat_NhanSu");

                entity.HasOne(d => d.MaPhatNavigation)
                    .WithMany(p => p.QuaTrinhPhat)
                    .HasForeignKey(d => d.MaPhat)
                    .HasConstraintName("FK_QuaTrinhPhat_Phat1");
            });

            modelBuilder.Entity<QuaTrinhPhuCap>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaHspc).HasColumnName("MaHSPC");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.MaPc).HasColumnName("MaPC");

                entity.Property(e => e.TgbatDau)
                    .HasColumnName("TGBatDau")
                    .HasColumnType("date");

                entity.Property(e => e.TgketThuc)
                    .HasColumnName("TGKetThuc")
                    .HasColumnType("date");

                entity.HasOne(d => d.MaHspcNavigation)
                    .WithMany(p => p.QuaTrinhPhuCap)
                    .HasForeignKey(d => d.MaHspc)
                    .HasConstraintName("FK_QuaTrinhPhuCap_DMHeSoPhuCap");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhPhuCap)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhPhuCap_NhanSu");

                entity.HasOne(d => d.MaPcNavigation)
                    .WithMany(p => p.QuaTrinhPhuCap)
                    .HasForeignKey(d => d.MaPc)
                    .HasConstraintName("FK_QuaTrinhPhuCap_DMMucPhuCap1");
            });

            modelBuilder.Entity<QuaTrinhThuongPc>(entity =>
            {
                entity.ToTable("QuaTrinhThuongPC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.Tgthuong)
                    .HasColumnName("TGThuong")
                    .HasColumnType("date");

                entity.Property(e => e.TienThuong).HasColumnType("money");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.QuaTrinhThuongPc)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_QuaTrinhThuongPC_NhanSu");

                entity.HasOne(d => d.MaThuongNavigation)
                    .WithMany(p => p.QuaTrinhThuongPc)
                    .HasForeignKey(d => d.MaThuong)
                    .HasConstraintName("FK_QuaTrinhThuongPC_ThuongPCKhac");
            });

            modelBuilder.Entity<Quyen>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaQuyen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenQuyen).HasMaxLength(100);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agn)
                    .HasColumnName("AGN")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.MaTk)
                    .IsRequired()
                    .HasColumnName("MaTK")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan1)
                    .HasColumnName("TaiKhoan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_TaiKhoan_NhanSu");

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.MaQuyen)
                    .HasConstraintName("FK_TaiKhoan_Quyen");
            });

            modelBuilder.Entity<Thue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaThue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ThueNhanSu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaNs).HasColumnName("MaNS");

                entity.Property(e => e.TienThue).HasColumnType("money");

                entity.HasOne(d => d.MaNsNavigation)
                    .WithMany(p => p.ThueNhanSu)
                    .HasForeignKey(d => d.MaNs)
                    .HasConstraintName("FK_ThueNhanSu_NhanSu");
            });

            modelBuilder.Entity<ThuongPckhac>(entity =>
            {
                entity.ToTable("ThuongPCKhac");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bhxh).HasColumnName("BHXH");

                entity.Property(e => e.MaThuong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoiDung).HasMaxLength(200);

                entity.Property(e => e.Tncn).HasColumnName("TNCN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
