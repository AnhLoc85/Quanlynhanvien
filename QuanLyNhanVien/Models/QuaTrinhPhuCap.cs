using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class QuaTrinhPhuCap
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public int? MaPc { get; set; }
        public int? MaHspc { get; set; }
        public DateTime? TgbatDau { get; set; }
        public DateTime? TgketThuc { get; set; }

        public virtual DmheSoPhuCap MaHspcNavigation { get; set; }
        public virtual NhanSu MaNsNavigation { get; set; }
        public virtual DmmucPhuCap MaPcNavigation { get; set; }
    }
}
