using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class Quyen
    {
        public Quyen()
        {
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        public int Id { get; set; }
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
