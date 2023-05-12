using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class QuaTrinhLuong
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public int? MaHsl { get; set; }
        public int? MaMl { get; set; }
        public DateTime? TgbatDau { get; set; }
        public DateTime? TgketThuc { get; set; }

        public virtual Dmhsluong MaHslNavigation { get; set; }
        public virtual Dmluong MaMlNavigation { get; set; }
        public virtual NhanSu MaNsNavigation { get; set; }
    }
}
