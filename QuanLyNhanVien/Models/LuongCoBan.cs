using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class LuongCoBan
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public DateTime? ThoiGian { get; set; }
        public double? Hsl { get; set; }
        public decimal? Luong { get; set; }
        public decimal? LuongNs { get; set; }

        public virtual NhanSu MaNsNavigation { get; set; }
    }
}
