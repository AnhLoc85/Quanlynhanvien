using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class ChamCong
    {
        public int Id { get; set; }
        public int? MaNs { get; set; }
        public DateTime? Ngay { get; set; }
        public TimeSpan? GioVaoSang { get; set; }
        public TimeSpan? GioRaSang { get; set; }
        public TimeSpan? GioVaoChieu { get; set; }
        public TimeSpan? GioRaChieu { get; set; }
        public TimeSpan? GioVaoToi { get; set; }
        public TimeSpan? GioRaToi { get; set; }
        public string Thu { get; set; }

        public virtual NhanSu MaNsNavigation { get; set; }
    }
}
