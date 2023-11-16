using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class ThueNhanSu
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public int? Thuesuat { get; set; }
        public decimal? TienThue { get; set; }
        public bool? Active { get; set; }

        public virtual NhanSu MaNsNavigation { get; set; }
    }
}
