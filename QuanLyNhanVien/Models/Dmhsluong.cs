using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class Dmhsluong
    {
        public Dmhsluong()
        {
            QuaTrinhLuong = new HashSet<QuaTrinhLuong>();
        }

        public int Id { get; set; }
        public string MaHsl { get; set; }
        public double? HeSoLuong { get; set; }

        public virtual ICollection<QuaTrinhLuong> QuaTrinhLuong { get; set; }
    }
}
