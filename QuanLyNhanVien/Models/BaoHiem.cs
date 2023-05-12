using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QuanLyNhanVien.Models
{
    public partial class BaoHiem
    {
        public BaoHiem()
        {
            QuaTrinhDongBh = new HashSet<QuaTrinhDongBh>();
        }

        public int Id { get; set; }
        public string MaBh { get; set; }
        public DateTime? Tgad { get; set; }
        public double? MucBaoHiem { get; set; }

        public virtual ICollection<QuaTrinhDongBh> QuaTrinhDongBh { get; set; }
    }
}
