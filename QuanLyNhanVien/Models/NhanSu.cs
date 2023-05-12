using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class NhanSu
    {
        public NhanSu()
        {
            LuongCoBan = new HashSet<LuongCoBan>();
            QtchucVu = new HashSet<QtchucVu>();
            QtcongTac = new HashSet<QtcongTac>();
            QuaTrinhDongBh = new HashSet<QuaTrinhDongBh>();
            QuaTrinhDongThue = new HashSet<QuaTrinhDongThue>();
            QuaTrinhLuong = new HashSet<QuaTrinhLuong>();
            QuaTrinhPhat = new HashSet<QuaTrinhPhat>();
            QuaTrinhPhuCap = new HashSet<QuaTrinhPhuCap>();
            QuaTrinhThuongPc = new HashSet<QuaTrinhThuongPc>();
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public int Id { get; set; }
        public string MaNs { get; set; }
        public string TenNs { get; set; }
        public bool? GioiTinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string HinhAnh { get; set; }
        public string QueQuan { get; set; }

        public virtual ICollection<LuongCoBan> LuongCoBan { get; set; }
        public virtual ICollection<QtchucVu> QtchucVu { get; set; }
        public virtual ICollection<QtcongTac> QtcongTac { get; set; }
        public virtual ICollection<QuaTrinhDongBh> QuaTrinhDongBh { get; set; }
        public virtual ICollection<QuaTrinhDongThue> QuaTrinhDongThue { get; set; }
        public virtual ICollection<QuaTrinhLuong> QuaTrinhLuong { get; set; }
        public virtual ICollection<QuaTrinhPhat> QuaTrinhPhat { get; set; }
        public virtual ICollection<QuaTrinhPhuCap> QuaTrinhPhuCap { get; set; }
        public virtual ICollection<QuaTrinhThuongPc> QuaTrinhThuongPc { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
