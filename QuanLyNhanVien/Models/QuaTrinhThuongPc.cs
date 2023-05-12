using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class QuaTrinhThuongPc
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public decimal? TienThuong { get; set; }
        public int? MaThuong { get; set; }
        public DateTime? Tgthuong { get; set; }

        public virtual NhanSu MaNsNavigation { get; set; }
        public virtual ThuongPckhac MaThuongNavigation { get; set; }
    }
}
