using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class HopDong
    {
        public int Id { get; set; }
        public string MaHd { get; set; }
        public int? MaNs { get; set; }
        public int? MaHspc { get; set; }
        public int? MaHsl { get; set; }
        public string ViTri { get; set; }
        public DateTime? NgayKy { get; set; }
        public DateTime? NgayBd { get; set; }

        public virtual Dmhsluong MaHslNavigation { get; set; }
        public virtual DmheSoPhuCap MaHspcNavigation { get; set; }
        public virtual NhanSu MaNsNavigation { get; set; }
    }
}
