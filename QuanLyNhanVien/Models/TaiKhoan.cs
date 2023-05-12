using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public int? MaQuyen { get; set; }
        public string MaTk { get; set; }
        public int? MaNs { get; set; }
        public string TaiKhoan1 { get; set; }
        public string MatKhau { get; set; }

        public virtual NhanSu MaNsNavigation { get; set; }
        public virtual Quyen MaQuyenNavigation { get; set; }
    }
}
