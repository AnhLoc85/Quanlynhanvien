using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class Dmluong
    {
        public Dmluong()
        {
            QuaTrinhLuong = new HashSet<QuaTrinhLuong>();
        }

        public int Id { get; set; }
        public string MaMl { get; set; }
        public decimal? TienLuong { get; set; }
        public DateTime? NgayAd { get; set; }

        public virtual ICollection<QuaTrinhLuong> QuaTrinhLuong { get; set; }
    }
}
