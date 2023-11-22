using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class LichLamViec
    {
        public int Id { get; set; }
        public TimeSpan? Vaosang { get; set; }
        public TimeSpan? Rasang { get; set; }
        public TimeSpan? Vaochieu { get; set; }
        public TimeSpan? Rachieu { get; set; }
        public TimeSpan? Vaotoi { get; set; }
        public TimeSpan? Ratoi { get; set; }
    }
}
